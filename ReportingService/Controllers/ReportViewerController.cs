using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.NETCore;
using Microsoft.ReportingServices.Interfaces;
using Newtonsoft.Json;
using ReportingService.Datas;
using ReportingService.Models;
using System.Linq;

namespace ReportingService.Controllers
{
    [Route("api/[controller]/[action]")]

    public class ReportViewerController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ReportingContext _reportContext;
        public ReportViewerController(IWebHostEnvironment webHostEnvironment, ReportingContext context)
        {
            _webHostEnvironment = webHostEnvironment;
            _reportContext = context;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult ReportingService(DateTime? fromDate, DateTime? toDate, string type, string extraParams)
        {
            if (fromDate == null)
            {
                fromDate = DateTime.Now.Date;
            }
            if (toDate == null)
            {
                toDate = DateTime.Now.Date;
            }

            string basePath = _webHostEnvironment.WebRootPath;
            string reportPath = "";
            switch (type)
            {
                case "welding":
                    reportPath = basePath + @"\Resources\weldingDailyReport.rdlc";
                    break;
                case "coating":
                    reportPath = basePath + @"\Resources\coatingDailyReport.rdlc";
                    break;
                case "assembling":
                    reportPath = basePath + @"\Resources\assemblingDailyReport.rdlc";
                    break;
                case "heattreat":
                    reportPath = basePath + @"\Resources\heattreatDailyReport.rdlc";
                    break;
                default:
                    reportPath = basePath + @"\Resources\heattreatDailyReport.rdlc";
                    break;


            }


            var result = _reportContext.DailyReports.FromSqlRaw("Exec GetDailyProduction @fromDate= {0}, @Todate={1} , " +
                "@Type= {2} ", fromDate, toDate, type);


            using (Stream stream = new FileStream(reportPath, FileMode.Open, FileAccess.Read))
            {


                using (LocalReport report = new LocalReport())
                {

                    report.LoadReportDefinition(stream);
                    report.DataSources.Add(new ReportDataSource("DataSet1", result));
                    byte[] reportData = report.Render("PDF");
                    return File(reportData, "application/pdf");
                }
            }

        }

        [HttpGet]

        public ActionResult DailyReportSummary(DateTime? fromDate, DateTime? toDate, string type, string extraParams)
        {
            if (fromDate == null)
            {
                fromDate = DateTime.Now.Date;
            }
            if (toDate == null)
            {
                toDate = DateTime.Now.Date;
            }

            string basePath = _webHostEnvironment.WebRootPath;
            string reportPath = basePath+ @"\Resources\summaryDailyReport.rdlc";
            


            var result = _reportContext.DailyReports.FromSqlRaw("Exec GetDailyProductionSummary @fromDate= {0}, @Todate={1} "
                , fromDate, toDate);


            using (Stream stream = new FileStream(reportPath, FileMode.Open, FileAccess.Read))
            {
                using (LocalReport report = new LocalReport())
                {

                    report.LoadReportDefinition(stream);
                    report.DataSources.Add(new ReportDataSource("DataSet1", result));
                    byte[] reportData = report.Render("PDF");
                    return File(reportData, "application/pdf");
                }
            }
        }
    }
}
