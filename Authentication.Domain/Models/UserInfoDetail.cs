using Authentication.Domain.Abstractions;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class UserInfoDetail : Entity<UserInfoDetailId>
    {
        public UserInfoId UserInfoId { get; set; } = default!;
        public string AccountCode { get; set; } = default!;
        public string AccountName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FacultyDetail { get; set; } = default!;


        public UserInfoDetail(UserInfoId userInfoId, string accountCode,
            string accountName, string password, string facultyDetail)
        {
            Id = UserInfoDetailId.Of(Guid.NewGuid());
            UserInfoId = userInfoId;
            AccountCode = accountCode;
            AccountName = accountName;
            Password = password;
            FacultyDetail = facultyDetail;
        }
        public UserInfoDetail(UserInfoDetailId id,
            UserInfoId userInfoId, string accountCode,
            string accountName, string password, string facultyDetail)
        {
            Id = id;
            UserInfoId = userInfoId;
            AccountCode = accountCode;
            AccountName = accountName;
            Password = password;
            FacultyDetail = facultyDetail;
        }
        public static UserInfoDetail Of(UserInfoDetailId id,
            UserInfoId userInfoId,
            string accountCode, string accountname, string password, string facultyDetail)
        {

            return new UserInfoDetail
                (id, userInfoId, accountCode, accountname, password, facultyDetail);
        }
    }
}
