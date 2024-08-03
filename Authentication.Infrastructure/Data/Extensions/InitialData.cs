using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<Menu> Menus =>
        new List<Menu>
        {
            Menu.Create(MenuId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), "Invoice", "Invoice","Invoice","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("189dc8dc-990f-48e0-a37b-e6f2b60b9d7d")), "Order", "Order","Order","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("0e9bb884-acf4-441a-bc21-e5d95dce0f3c")), "UserInfo", "UserInfo","UserInfo","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("2e87abb5-3de0-49be-a68e-5c411247df9a")), "UserInfoMenu", "UserInfo Menu","UserInfoMenu","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("63752897-c8e2-4cc0-a3f7-dafa76ac9f6d")), "UserInfoAction", "UserInfo Action","UserInfoAction","","","","","",true),

        };
        public static IEnumerable<Module> Forms =>
        new List<Module>
        {
            Module.Create(ModuleId.Of(new Guid("2617968e-90a1-4ac8-b0c1-ed133b84750c")), "Invoice", "Invoice","Invoice","1","client","name","name","Number"
                ,"number",1,"invoice","invoice_list","add_new_invoice","invoice","record_payment","string","",
                "","","","",true),

           Module.Create(ModuleId.Of(new Guid("80a5d47e-fc1c-4152-bcf2-b1657b4658ab")), "Invoice", "Invoice","Invoice","1","client","name","name","Client"
                ,"client,name",2,"invoice","invoice_list","add_new_invoice","invoice","record_payment","string","",
                "","","","",true),
            Module.Create(ModuleId.Of(new Guid("28ad011a-89ea-4525-91cd-1c3b2f04ebb4")), "Invoice", "Invoice","Invoice","1","client","name","name","Date"
                ,"date",3,"invoice","invoice_list","add_new_invoice","invoice","record_payment","date","",
                "","","","",true),
            Module.Create(ModuleId.Of(new Guid("5c64cd06-d70d-42af-a880-a36d8f828441")), "Invoice", "Invoice","Invoice","1","client","name","name","Expired Date"
                ,"expiredDate",4,"invoice","invoice_list","add_new_invoice","invoice","record_payment","date","",
                "","","","",true),
            Module.Create(ModuleId.Of(new Guid("b9016afa-2c51-46e0-a3bc-2f9a94803fe5")), "Invoice", "Invoice","Invoice","1","client","name","name","Total"
                ,"total",5,"invoice","invoice_list","add_new_invoice","invoice","record_payment","money","",
                "","","","",true),
             Module.Create(ModuleId.Of(new Guid("f5983e12-7e06-49bf-897f-c003a9eabecf")), "Invoice", "Invoice","Invoice","1","client","name","name","Status"
                ,"status",6,"invoice","invoice_list","add_new_invoice","invoice","record_payment","status","",
                "","","","",true),
              Module.Create(ModuleId.Of(new Guid("b42f326b-a40d-4bc3-bf29-2cda2d1c24eb")), "Invoice", "Invoice","Invoice","1","client","name","name","Payment"
                ,"paymentStatus",7,"invoice","invoice_list","add_new_invoice","invoice","record_payment","status","",
                "","","","",true),
               Module.Create(ModuleId.Of(new Guid("54371610-4035-46d5-bce7-0215854b9211")), "UserInfo", "UserInfo","UserInfo","1","client","name","name","UserInfoCode"
                ,"userInfoCode",1,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),
               Module.Create(ModuleId.Of(new Guid("473aef5e-3a2f-420e-b80c-8a77a187a8a7")), "UserInfo", "UserInfo","UserInfo","1","client","name","name","FirstName"
                ,"firstName",2,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),
                Module.Create(ModuleId.Of(new Guid("09f8fa39-d085-4643-be21-212b030bf244")), "UserInfo", "UserInfo","UserInfo","1","client","name","name","LastName"
                ,"lastName",3,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),
                 Module.Create(ModuleId.Of(new Guid("36427bf0-7cba-47b7-b75c-252ffe787436")), "UserInfo", "UserInfo","UserInfo","1","client","name","name","FullName"
                ,"fullName",4,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),


                 

        };
        public static IEnumerable<Form> FormsDetails =>
            new List<Form>
            {
                Form.Create(FormId.Of(new Guid("32141e8d-3ae4-4a32-972d-39bb8d6f44bf")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","client","name","name","Add New Client","/customer",
                    "Client","client",new []{"require: true"},"8",1,"Invoice","","string","","","","","",true),
                Form.Create(FormId.Of(new Guid("44dd63b8-0d17-4a5d-8892-8895647d58bd")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","","","","","",
                    "Number","number",new []{"require: true"},"3",2,"Invoice","","number","","","","","",true),
                 Form.Create(FormId.Of(new Guid("baff97c3-3e60-4d74-a197-e8aca4f8dc76")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","","","","","",
                    "Year","year",new []{"require: true"},"3",3,"Invoice","","number","","","","","",true),
                Form.Create(FormId.Of(new Guid("ab636f27-96f3-448a-ab4d-3c31f5a9e50e")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","","","","","",
                    "Status","status",new []{"require: true"},"5",4,"Invoice","","select","'drap,'Drap'; 'pending,'Pending'; 'sent','Sent'"
                    ,"","","","",true),
                 Form.Create(FormId.Of(new Guid("1d30ff8f-bb3d-4a05-8075-1a9996333ac1")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","","","","","",
                    "Date","date",new []{"require: true"},"8",5,"Invoice","","date","","","","","",true),
                  Form.Create(FormId.Of(new Guid("6e29dfb9-f0df-4c27-8115-636cb2b889ac")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","","","","","",
                    "Expire date","expiredDate",new []{"require: true"},"6",6,"Invoice","","date","","","","","",true),
                  Form.Create(FormId.Of(new Guid("2c623d46-0ea2-46ef-aed4-c9681ed3027d")),"Invoice","Invoice",
                    "Invoice","Invoice","1","1","","","","","",
                    "Notes","notes",new []{"req: false"},"10",7,"Invoice","","string","","","","","",true),
                  Form.Create(FormId.Of(new Guid("1fcd2506-cfe1-403a-aba5-21afa03917c8")),"Invoice","Invoice",
                    "Invoice","Invoice","2","1","","","","","",
                    "Item","itemName",new []{"require: true, pattern:true"},"5",8,"Invoice","","string","","","","","",true),
                   Form.Create(FormId.Of(new Guid("27e8c273-755a-44de-81ce-b3f430be543f")),"Invoice","Invoice",
                    "Invoice","Invoice","2","1","","","","","",
                    "Description","description",new []{"require: true"},"7",9,"Invoice","","string","","description Name","","","",true),
                   Form.Create(FormId.Of(new Guid("af5a9fd6-7676-456f-9190-8e62b74e9b7d")),"Invoice","Invoice",
                    "Invoice","Invoice","2","1","","","","","",
                    "Quantity","quantity",new []{"require: true"},"3",10,"Invoice","","number","","Quantity","","","",true),
                   Form.Create(FormId.Of(new Guid("3d63e843-9b91-40c3-ae57-e8533ae2c9e6")),"Invoice","Invoice",
                    "Invoice","Invoice","2","1","","","","","",
                    "Price","price",new []{"require: true"},"4",11,"Invoice","","money","","Price","","","",true),
                   Form.Create(FormId.Of(new Guid("0f4bfb95-4859-45e7-82ff-21d0475c54b2")),"Invoice","Invoice",
                    "Invoice","Invoice","2","1","","","","","",
                    "Total","total",new []{"req: false"},"5",12,"Invoice","","money","","","","","",true),
                    
                    Form.Create(FormId.Of(new Guid("7aad6f40-0391-4ca8-ae29-4e91d887b2c8")),"UserInfo","UserInfo",
                    "UserInfo","UserInfo","1","1","","","","","",
                    "User Code","userInfoCode",new []{"require: true,pattern:true"},"5",1,"UserInfo","","string","","","","","",true),
                      Form.Create(FormId.Of(new Guid("b5b89544-46d9-4166-9d07-34a575ac7ab8")),"UserInfo","UserInfo",
                    "UserInfo","UserInfo","1","1","","","","","",
                    "FirstName","firstName",new []{"require: true,pattern:true"},"5",2,"UserInfo","","string","","","","","",true),
                      Form.Create(FormId.Of(new Guid("05adb6ad-72bb-4d19-94bd-2a503853980f")),"UserInfo","UserInfo",
                    "LastName","LastName","1","1","","","","","",
                    "LastName","lastName",new []{"require: true,pattern:true"},"5",3,"UserInfo","","string","","","","","",true),
                       Form.Create(FormId.Of(new Guid("e76e154a-5709-44e3-8cc5-10eb1bdf786c")),"UserInfo","UserInfo",
                    "FullName","FullName","1","1","","","","","",
                    "FullName","fullName",new []{"require: true,pattern:true"},"5",4,"UserInfo","","string","","","","","",true),
                       Form.Create(FormId.Of(new Guid("5199c11a-e5c0-4a6a-aeab-25fe3e7af344")),"UserInfo","UserInfo",
                    "BirthDate","BirthDate","1","1","","","","","",
                    "BirthDate","birthDate",new []{"req: false,pattern:true"},"5",5,"UserInfo","","string","","","","","",true),
                       Form.Create(FormId.Of(new Guid("88fad724-a920-4955-952d-5703a89d5b65")),"UserInfo","UserInfo",
                    "Year","Year","1","1","","","","","",
                    "Year","year",new []{"req: false,pattern:true"},"5",6,"UserInfo","","string","","","","","",true),
                       Form.Create(FormId.Of(new Guid("9da7c905-6740-4f34-a44a-a3191ace6ed8")),"UserInfoDetail","UserInfoDetail",
                    "AccountCode","AccountCode","2","1","","","","","",
                    "Account Code","accountCode",new []{"require: true,pattern:true"},"5",1,"UserInfo","","string","","","","","",true),
                       Form.Create(FormId.Of(new Guid("922fe287-af9f-4d2e-9a54-17db9bce950b")),"UserInfoDetail","UserInfoDetail",
                    "AccountName","AccountName","2","1","","","","","",
                    "Account Name","accountName",new []{"require: true,pattern:true"},"5",2,"UserInfo","","string","","","","","",true),
                        Form.Create(FormId.Of(new Guid("23fd5117-38b2-4cfd-8ed1-c23dda08f2c6")),"UserInfo","UserInfo",
                    "Password","Password","2","1","","","","","",
                    "Password","password",new []{"require: true"},"5",3,"UserInfo","","string","","","","","",true),
                         Form.Create(FormId.Of(new Guid("bf83dfcf-4590-4b28-bae4-36addb8072a7")),"UserInfo","UserInfo",
                    "FacultyDetail","FacultyDetail","2","1","","","","","",
                    "FacultyDetail","facultyDetail",new []{"require: true"},"5",4,"UserInfo","","string","","","","","",true),

                Form.Create(FormId.Of(new Guid("8f1366f6-b84c-4e24-81f6-90bb70f951c2")),"UserInfoMenu","UserInfoMenu",
                    "MenuCode","MenuCode","2","1","","","","","",
                    "MenuCode","menuCode",new []{"require: true"},"5",1,"UserInfoMenu","menus","string","","","","","",true),
                Form.Create(FormId.Of(new Guid("7e5f9ce1-4598-4d19-8598-c82750216d91")),"UserInfoMenu","UserInfoMenu",
                    "Name","Name","2","1","","","","","",
                    "Name","name",new []{"require: true"},"5",2,"UserInfoMenu","menus","string","","","","","",true),


                Form.Create(FormId.Of(new Guid("b6476178-11f2-4b01-9951-865492da0470")),"UserInfoAction","UserInfoAction",
                    "ActionCode","ActionCode","2","1","","","","","",
                    "MenuCode","actionCode",new []{"require: true"},"5",1,"UserInfoAction","actionInfos","string","","","","","",true),
                Form.Create(FormId.Of(new Guid("c96d6be8-1bc4-498b-892d-f9f41b4b48b0")),"UserInfoAction","UserInfoAction",
                    "ModuleCode","ModuleCode","2","1","","","","","",
                    "ModuleCode","moduleCode",new []{"require: true"},"5",2,"UserInfoAction","actionInfos","string","","","","","",true),
                Form.Create(FormId.Of(new Guid("b892f584-a548-4f6a-8ca3-dd7a908e52cd")),"UserInfoAction","UserInfoAction",
                    "Name","Name","2","1","","","","","",
                    "Name","name",new []{"require: true"},"5",3,"UserInfoAction","actionInfos","string","","","","","",true)

            };

        public static IEnumerable<ActionInfo> ActionInfos =>
           new List<ActionInfo>
           {
                ActionInfo.Create(ActionInfoId.Of(new Guid("32141e8d-3ae4-4a32-972d-39bb8d6f44bf")),
                    "read","Show","Invoice","","1","","read","Show","handleRead",1,
                    "","","","","","",true),

                ActionInfo.Create(ActionInfoId.Of(new Guid("5169cb4b-5f83-4745-8382-45a2db6ba8d5")),
                    "edit","Edit","Invoice","","1","","edit","Edit","handleEdit",2,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("f0d8431e-787c-4c3d-84ed-51d028709004")),
                    "delete","Delete","Invoice","","1","","delete","Delete","handleDelete",3,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("7a75961d-becf-4f36-89ed-4061526ddd65")),
                    "download","Download","Invoice","","1","","download","Download","handleDownload",4,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("7e06a91b-277e-4050-9199-2e0f8fdeef35")),
                    "recordPayment","RecordPayment","Invoice","","1","","recordPayment","RecordPayment","handleRecordPayment",5,
                    "","","","","","",true),
                 ActionInfo.Create(ActionInfoId.Of(new Guid("bc8b194e-8516-45b7-8a4a-fd3d87296f48")),
                    "addNewItem","AddNewItem","Invoice","","1","","AddNewItem","AddNewItem","handleClick",6,
                    "","","","","","",true),


                 ActionInfo.Create(ActionInfoId.Of(new Guid("0eeb2620-5def-4198-b371-42da45bec4db")),
                    "read","Show","userinfo","","1","","read","Show","handleRead",1,
                    "","","","","","",true),

                ActionInfo.Create(ActionInfoId.Of(new Guid("e994a210-10fb-417d-bff8-f6939d4c128b")),
                    "edit","Edit","userinfo","","1","","edit","Edit","handleEdit",2,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("daee4019-441a-41f8-835f-41c1b53104c1")),
                    "delete","Delete","userinfo","","1","","delete","Delete","handleDelete",3,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("645a5ed8-4fb1-433e-9a91-81ee716beb2e")),
                    "download","Download","userinfo","","1","","download","Download","handleDownload",4,
                    "","","","","","",true),               
                 ActionInfo.Create(ActionInfoId.Of(new Guid("9957c8bf-e5db-4973-a24a-a7cad14732d7")),
                    "addNewItem","AddNewItem","userinfo","","1","","AddNewItem","AddNewItem","handleClick",6,
                    "","","","","","",true),

                  ActionInfo.Create(ActionInfoId.Of(new Guid("01be0e8f-2c01-47b3-a194-1ff9a00b50a3")),
                    "read","Show","userinfomenu","","1","","read","Show","handleRead",1,
                    "","","","","","",true),


                ActionInfo.Create(ActionInfoId.Of(new Guid("c1d114df-c943-4e60-8fa7-29c25d49f4f4")),
                    "edit","Edit","userinfomenu","","1","","edit","Edit","handleEdit",2,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("e6e36d62-706d-490c-bfbd-026cdd679b79")),
                    "delete","Delete","userinfomenu","","1","","delete","Delete","handleDelete",3,
                    "","","","","","",true),
                ActionInfo.Create(ActionInfoId.Of(new Guid("09efd87d-941c-4ce2-8cd7-eeaeb278ef0d")),
                    "download","Download","userinfomenu","","1","","download","Download","handleDownload",4,
                    "","","","","","",true),
                 ActionInfo.Create(ActionInfoId.Of(new Guid("c201ea0b-8c02-4433-a7e0-a91029c73660")),
                    "addNewItem","AddNewItem","userinfomenu","","1","","AddNewItem","AddNewItem","handleClick",5,
                    "","","","","","",true),
           };
    }
}
