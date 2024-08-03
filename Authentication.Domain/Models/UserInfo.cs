using Authentication.Domain.Abstractions;
using Authentication.Domain.ValueObjects;
using System.Runtime.CompilerServices;

namespace Authentication.Domain.Models
{
    public class UserInfo : Aggregate<UserInfoId>
    {

        public List<UserInfoDetail> _items = new();
        public List<UserInfoDetail> Items => _items;
        private List<UserInfoMenu> _itemMenus = new();
        public List<UserInfoMenu> ItemMenus => _itemMenus;

        private List<UserInfoAction> _itemActions = new();
        public List<UserInfoAction> ItemActions => _itemActions;

        public string UserInfoCode { get; private set; } = default!;
        public string FirstName { get; private set; } = default!;
        public string LastName { get; private set; } = default!;
        public string FullName { get; private set; } = default!;
        public string BirthDate { get; private set; } = default!;
        public string Year { get; private set; } = default!;


        public static UserInfo Create(UserInfoId id, string userInfoCode, string firstName, string lastName,
            string fullName, string birthDate, string year)
        {
            var userInfo = new UserInfo()
            {
                Id = id,
                UserInfoCode = userInfoCode,
                FirstName = firstName,
                LastName = lastName,
                FullName = fullName,
                BirthDate = birthDate,
                Year = year
            };
            return userInfo;
        }
        public void Add(string accountCode, string accountName, string password, string facultyDetail)
        {

            ArgumentNullException.ThrowIfNullOrWhiteSpace(accountCode);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(accountName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(password);


            var userInfoDetail = new UserInfoDetail(Id, accountCode, accountName, password, facultyDetail);
            _items.Add(userInfoDetail);

        }

        public void Update(UserInfoDetailId id, string accountCode, string accountName, string password, string facultyDetail)
        {

            ArgumentNullException.ThrowIfNullOrWhiteSpace(accountCode);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(accountName);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(password);


            var userInfoDetail = new UserInfoDetail(id, Id, accountCode, accountName, password, facultyDetail);
            _items.Add(userInfoDetail);

        }
        public void Update(string userInfoCode, string firstName, string lastName,
            string fullName, string birthDate, string year)
        {
            UserInfoCode = userInfoCode;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            BirthDate = birthDate;
            Year = year;

        }
    }
}
