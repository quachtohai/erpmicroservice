using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using ReportingService.Models;


namespace ReportingService.Controllers
{
    [Route("api/[controller]/[action]")]
    
    public class ReportViewerController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportViewerController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Index1()
        {
           
            string basePath = _webHostEnvironment.WebRootPath;
            
            string reportPath = basePath + @"\Resources\materialInfo.rdlc";           
           
            MaterialInfo materialInfo = new MaterialInfo()
            {
                MaterialCode = "VT001",
                MaterialName = "VT001",
                Description = "VT001",
                Id = 1,
                IsActive = true,
            };
            List<MaterialInfo> materials = new List<MaterialInfo>() { materialInfo };
            using (Stream stream = new FileStream(reportPath, FileMode.Open, FileAccess.Read))
            {
               

                using (LocalReport report = new LocalReport())
                {
                    report.LoadReportDefinition(stream);
                    report.DataSources.Add(new ReportDataSource("DataSet1", materials));
                    byte[] reportData = report.Render("PDF");
                    return File(reportData, "application/pdf");
                }
            }

        }

        


    }
}
