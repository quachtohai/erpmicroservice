using Authentication.Domain.Abstractions;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class Menu :Entity<MenuId>
    {
        public string MenuCode { get; private set; } = default!;
        public string Name { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public string Description2 { get; private set; } = default!;
        public string Description3 { get; private set; } = default!;
        public string Description4 { get; private set; } = default!;
        public string Description5 { get; private set; } = default!;
        public string Description6 { get; private set; } = default!;
        public bool Status { get; private set; } = default!;
        public static Menu Create(MenuId id, string menuCode,string name, string description,
            string description2, string description3, string description4, string description5,
            string description6, bool status
            )
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(menuCode);
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            var menu = new Menu
            {
                Id = id,
                MenuCode = menuCode,
                Name = name,
                Description =description,
                Description2 = description2,
                Description3 = description3,
                Description4 = description4,
                Description5 = description5,
                Description6 = description6,
                Status = status
            };

            return menu;
        }
    }
}
