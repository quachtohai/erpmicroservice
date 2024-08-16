using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class CompanyInfo : Entity<CompanyInfoId>
    {
        public string Name { get; private set; } = default!;
        public string Contact { get; private set; } = default!;
        public string Country { get; private set; } = default!;
        public string Phone { get; private set; } = default!;
        public string Email { get; private set; } = default!;
        public string Website { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public string Description2 { get; private set; } = default!;
        public string Description3 { get; private set; } = default!;
        public string Description4 { get; private set; } = default!;
        public string Description5 { get; private set; } = default!;
        public static CompanyInfo Create(CompanyInfoId id,
            string name, string contact, string country, string phone, string email, string website, string description,
            string description2, string description3, string description4, string description5
           )
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            var companyInfo = new CompanyInfo()
            {
                Id = id,
                Name = name,
                Contact = contact,
                Country = country,
                Phone = phone,
                Email = email,
                Website = website,
                Description = description,
                Description2 = description2,
                Description3 = description3,
                Description4 = description4,
                Description5 = description5,
            };
            return companyInfo;


        }
        public void Update(string name, string contact, string country, string phone, string email, string website, string description,
            string description2, string description3, string description4, string description5)
        {
            Name = name;
            Contact = contact;
            Country = country;
            Phone = phone;
            Email = email;
            Website = website;
            Description = description;
            Description2 = description2;
            Description3 = description3;
            Description4 = description4;
            Description5 = description5;


        }

    }

}
