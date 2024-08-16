namespace Authentication.Infrastructure.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<Menu> Menus =>
        new List<Menu>
        {
            //Menu.Create(MenuId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), "Invoice", "Invoice","Invoice","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("189dc8dc-990f-48e0-a37b-e6f2b60b9d7d")), "Order", "Order","Order","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("0e9bb884-acf4-441a-bc21-e5d95dce0f3c")), "UserInfo", "UserInfo","UserInfo","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("2e87abb5-3de0-49be-a68e-5c411247df9a")), "UserInfoMenu", "UserInfo Menu","UserInfoMenu","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("63752897-c8e2-4cc0-a3f7-dafa76ac9f6d")), "UserInfoAction", "UserInfo Action","UserInfoAction","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("81933031-b8c7-4ee8-92f0-23e42ad07d1f")), "Company", "Company","Company","","","","","",true),
            Menu.Create(MenuId.Of(new Guid("222786ac-4720-496c-aec4-8980a1b66643")), "Reporting", "Reporting","Reporting","Report","","","","",true),
            Menu.Create(MenuId.Of(new Guid("dad2c203-962d-41c4-a277-4a267dc6449f")), "Product", "Product","Product","Product","","","","",true),
            Menu.Create(MenuId.Of(new Guid("28e03d5b-549f-431e-a667-8ca31787ff2d")), "DictionaryInfo", "Planning Configuration","DictionaryInfo","Planning Configuration","","","","",true),
            Menu.Create(MenuId.Of(new Guid("6df1de91-2302-4f26-8af9-5e835dd4cdcb")), "DailyProduction", "DailyProduction","DailyProduction","DailyProduction","","","","",true),

        };
        public static IEnumerable<Module> Forms =>
        new List<Module>
        {
            Module.Create(ModuleId.Of(new Guid("2617968e-90a1-4ac8-b0c1-ed133b84750c")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Number"
                ,"number",1,"invoice","invoice_list","add_new_invoice","invoice","record_payment","string","",
                "","","","",true),

           Module.Create(ModuleId.Of(new Guid("80a5d47e-fc1c-4152-bcf2-b1657b4658ab")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Client"
                ,"client,name",2,"invoice","invoice_list","add_new_invoice","invoice","record_payment","string","",
                "","","","",true),
            Module.Create(ModuleId.Of(new Guid("28ad011a-89ea-4525-91cd-1c3b2f04ebb4")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Date"
                ,"date",3,"invoice","invoice_list","add_new_invoice","invoice","record_payment","date","",
                "","","","",true),
            Module.Create(ModuleId.Of(new Guid("5c64cd06-d70d-42af-a880-a36d8f828441")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Expired Date"
                ,"expiredDate",4,"invoice","invoice_list","add_new_invoice","invoice","record_payment","date","",
                "","","","",true),
            Module.Create(ModuleId.Of(new Guid("b9016afa-2c51-46e0-a3bc-2f9a94803fe5")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Total"
                ,"total",5,"invoice","invoice_list","add_new_invoice","invoice","record_payment","money","",
                "","","","",true),
             Module.Create(ModuleId.Of(new Guid("f5983e12-7e06-49bf-897f-c003a9eabecf")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Status"
                ,"status",6,"invoice","invoice_list","add_new_invoice","invoice","record_payment","status","",
                "","","","",true),
              Module.Create(ModuleId.Of(new Guid("b42f326b-a40d-4bc3-bf29-2cda2d1c24eb")), "Invoice", "Invoice","Invoice","1","userinfo","fullName","FullName","Payment"
                ,"paymentStatus",7,"invoice","invoice_list","add_new_invoice","invoice","record_payment","status","",
                "","","","",true),
               Module.Create(ModuleId.Of(new Guid("54371610-4035-46d5-bce7-0215854b9211")), "UserInfo", "UserInfo","UserInfo","1","userinfo","fullName","FullName","UserInfoCode"
                ,"userInfoCode",1,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),
               Module.Create(ModuleId.Of(new Guid("473aef5e-3a2f-420e-b80c-8a77a187a8a7")), "UserInfo", "UserInfo","UserInfo","1","userinfo","fullName","FullName","FirstName"
                ,"firstName",2,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),
                Module.Create(ModuleId.Of(new Guid("09f8fa39-d085-4643-be21-212b030bf244")), "UserInfo", "UserInfo","UserInfo","1","userinfo","fullName","FullName","LastName"
                ,"lastName",3,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),
                 Module.Create(ModuleId.Of(new Guid("36427bf0-7cba-47b7-b75c-252ffe787436")), "UserInfo", "UserInfo","UserInfo","1","userinfo","fullName","FullName","FullName"
                ,"fullName",4,"userinfo","User_Info_list","add_new_userInfo","UserInfo","","string","",
                "","","","",true),

                  Module.Create(ModuleId.Of(new Guid("3a7b12eb-1afb-4ec2-90b2-adf3a2c3c4da")), moduleCode:"CompanyInfo", name:"CompanyInfo",entity:"CompanyInfo",type:"1",entitysearch:"companyinfo",
                      displaylabels:"name",searchfields:"Name,Phone,Email",title:"Name"
                ,dataindex:"name",order: 1,panel_title:"company",database_title:"Company_List",addNewEntity:"add_new_companyInfo",entityname:"CompanyInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                   Module.Create(ModuleId.Of(new Guid("75cf11dc-3f0a-42a7-b567-5d4bf109a41b")), moduleCode:"CompanyInfo", name:"CompanyInfo",entity:"CompanyInfo",type:"1",entitysearch:"companyinfo",
                      displaylabels:"name",searchfields:"Name,Phone,Email",title:"Contact"
                ,dataindex:"contact",order: 2,panel_title:"company",database_title:"Company_List",addNewEntity:"add_new_companyInfo",entityname:"CompanyInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                    Module.Create(ModuleId.Of(new Guid("5cc013ff-9075-4fec-8845-d3df3e7b247e")), moduleCode:"CompanyInfo", name:"CompanyInfo",entity:"CompanyInfo",type:"1",entitysearch:"companyinfo",
                      displaylabels:"name",searchfields:"Name,Phone,Email",title:"Country"
                ,dataindex:"country",order: 3,panel_title:"company",database_title:"Company_List",addNewEntity:"add_new_companyInfo",entityname:"CompanyInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                    Module.Create(ModuleId.Of(new Guid("1dd2bee0-e268-4a87-bfd4-430c07b3925a")), moduleCode:"CompanyInfo", name:"CompanyInfo",entity:"CompanyInfo",type:"1",entitysearch:"companyinfo",
                      displaylabels:"name",searchfields:"Name,Phone,Email",title:"Phone"
                ,dataindex:"phone",order: 4,panel_title:"company",database_title:"Company_List",addNewEntity:"add_new_companyInfo",entityname:"CompanyInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                    Module.Create(ModuleId.Of(new Guid("0314cd12-0d9b-4f52-b271-a01cb7ff8754")), moduleCode:"CompanyInfo", name:"CompanyInfo",entity:"CompanyInfo",type:"1",entitysearch:"companyinfo",
                      displaylabels:"name",searchfields:"Name,Phone,Email",title:"Email"
                ,dataindex:"email",order: 5,panel_title:"company",database_title:"Company_List",addNewEntity:"add_new_companyInfo",entityname:"CompanyInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                    Module.Create(ModuleId.Of(new Guid("19e754d8-fc42-4691-bcb7-d1f3b857f20f")), moduleCode:"CompanyInfo", name:"CompanyInfo",entity:"CompanyInfo",type:"1",entitysearch:"companyinfo",
                      displaylabels:"name",searchfields:"Name,Phone,Email",title:"Website"
                ,dataindex:"website",order: 6,panel_title:"company",database_title:"Company_List",addNewEntity:"add_new_companyInfo",entityname:"CompanyInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                     Module.Create(ModuleId.Of(new Guid("34fe70b1-ca99-4fd8-ba5a-af2cb0c8c5e6")), moduleCode:"Product", name:"Product",entity:"Product",type:"1",
                         entitysearch:"product",displaylabels:"productName",searchfields:"ProductName",title:"ProductName (Loại khung)"
                ,dataindex:"productName",order: 1,panel_title:"product",database_title:"Product_List",addNewEntity:"add_new_product",entityname:"Product",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                     Module.Create(ModuleId.Of(new Guid("7eabe876-4d4f-49b3-8c64-05f14346602e")), moduleCode:"Product", name:"Product",entity:"Product",type:"1",
                         entitysearch:"product",displaylabels:"productName",searchfields:"ProductName",title:"ItemCode 01 (Mã sản phẩm 1)"
                ,dataindex:"productCode01",order: 2,panel_title:"product",database_title:"Product_List",addNewEntity:"add_new_product",entityname:"Product",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                     Module.Create(ModuleId.Of(new Guid("9587159c-44b5-4a25-81ea-1db8b7acd43e")), moduleCode:"Product", name:"Product",entity:"Product",type:"1",
                         entitysearch:"product",displaylabels:"productName",searchfields:"ProductName",title:"ItemCode 02 (Mã sản phẩm 2)"
                ,dataindex:"productCode02",order: 3,panel_title:"product",database_title:"Product_List",addNewEntity:"add_new_product",entityname:"Product",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                     Module.Create(ModuleId.Of(new Guid("ecf83c9c-d290-4518-8ecf-f9cfa692e9d2")), moduleCode:"Product", name:"Product",entity:"Product",type:"1",
                         entitysearch:"product",displaylabels:"productName",searchfields:"ProductName",title:"Process (Công đoạn)"
                ,dataindex:"process",order: 4,panel_title:"product",database_title:"Product_List",addNewEntity:"add_new_product",entityname:"Product",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                     Module.Create(ModuleId.Of(new Guid("392c9577-c6e8-4bb3-bae2-3c0081aeecb7")), moduleCode:"Product", name:"Product",entity:"Product",type:"1",
                         entitysearch:"product",displaylabels:"productName",searchfields:"ProductName",title:"Desciption (Công đoạn)"
                ,dataindex:"description",order: 5,panel_title:"product",database_title:"Product_List",addNewEntity:"add_new_product",entityname:"Product",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                       Module.Create(ModuleId.Of(new Guid("ec33012d-2f35-4007-9d55-765dc06fc099")), moduleCode:"DictionaryInfo", name:"DictionaryInfo",entity:"DictionaryInfo",type:"1",
                         entitysearch:"dictionaryInfo",displaylabels:"dictionaryInfoName",searchfields:"DictionaryInfoName",title:"DictionaryInfoName (Tên cấu hình)"
                ,dataindex:"dictionaryInfoName",order: 1,panel_title:"dictionaryInfo",database_title:"DictionaryInfo_List",addNewEntity:"add_new_dictionaryInfo",entityname:"DictionaryInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),
                       Module.Create(ModuleId.Of(new Guid("484427d6-8328-4a89-8ffb-bb94630eb50f")), moduleCode:"DictionaryInfo", name:"DictionaryInfo",entity:"DictionaryInfo",type:"1",
                         entitysearch:"dictionaryInfo",displaylabels:"dictionaryInfoName",searchfields:"DictionaryInfoName",title:"DictionaryInfoCode (Code cấu hình)"
                ,dataindex:"dictionaryInfoCode",order: 2,panel_title:"dictionaryInfo",database_title:"DictionaryInfo_List",addNewEntity:"add_new_dictionaryInfo",entityname:"DictionaryInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),
                        Module.Create(ModuleId.Of(new Guid("fc5e2cf1-437a-4e32-b1e2-af2dad81d38b")), moduleCode:"DictionaryInfo", name:"DictionaryInfo",entity:"DictionaryInfo",type:"1",
                         entitysearch:"dictionaryInfo",displaylabels:"dictionaryInfoName",searchfields:"DictionaryInfoName",title:"Description (Diễn giải)"
                ,dataindex:"description",order: 3,panel_title:"dictionaryInfo",database_title:"DictionaryInfo_List",addNewEntity:"add_new_dictionaryInfo",entityname:"DictionaryInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),
                         Module.Create(ModuleId.Of(new Guid("0b69f099-d02a-4228-9586-3bfb6ebf28b8")), moduleCode:"DictionaryInfo", name:"DictionaryInfo",entity:"DictionaryInfo",type:"1",
                         entitysearch:"dictionaryInfo",displaylabels:"dictionaryInfoName",searchfields:"DictionaryInfoName",title:"Process (Loại)"
                ,dataindex:"process",order: 4,panel_title:"dictionaryInfo",database_title:"DictionaryInfo_List",addNewEntity:"add_new_dictionaryInfo",entityname:"DictionaryInfo",recordentityname:"",description:"string",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                         Module.Create(ModuleId.Of(new Guid("d58dc7f6-c3a0-4f55-af86-daa78a7329b6")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"Date (Ngày)"
                ,dataindex:"date",order: 1,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"date",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                         Module.Create(ModuleId.Of(new Guid("0370fa5d-bf04-4628-84a0-150568fa5e0a")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"ProductId (Id Khung)"
                ,dataindex:"productId",order: 2,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),
                         Module.Create(ModuleId.Of(new Guid("2ecd27d4-6eef-4393-88a1-7be2f426f772")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"ProductName (Loại Khung)"
                ,dataindex:"productName",order: 3,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),
                         Module.Create(ModuleId.Of(new Guid("44589c8d-7770-4da2-b126-2980cc3988f1")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"TotalQuantity (Tổng số lượng)"
                ,dataindex:"totalQuantity",order: 4,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),
                         Module.Create(ModuleId.Of(new Guid("b8cc4748-0017-473e-a6a8-80efd1f591f0")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"NG Welding Qty (Tổng số lượng hàn NG)"
                ,dataindex:"ngQuantity1",order: 5,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                         Module.Create(ModuleId.Of(new Guid("6a3c4839-ca2a-48ff-b621-96f612bf7d8f")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"NG Reaming Qty (Số lượng Doa NG)"
                ,dataindex:"ngQuantity2",order: 6,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                         Module.Create(ModuleId.Of(new Guid("e4b55113-4d8a-48cf-9458-0456266525b0")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"Goods Quantity (Số lượng thành phẩm)"
                ,dataindex:"goodsQuantity",order: 7,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                         Module.Create(ModuleId.Of(new Guid("943812c5-2dd2-44c8-80eb-02d25da92eef")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"QC Quantity (Số lượng QC test)"
                ,dataindex:"qcQuantity",order: 8,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                        Module.Create(ModuleId.Of(new Guid("ea4f7fb3-0014-409d-8e69-fda3213ef959")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"Income quantity (Số lượng còn lại)"
                ,dataindex:"incomeQuantity",order: 8,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


                        Module.Create(ModuleId.Of(new Guid("ab40cbd8-7546-4d75-b1f5-d6872e57a58c")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"ManPower (Số người)"
                ,dataindex:"manPower",order: 9,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                          Module.Create(ModuleId.Of(new Guid("622583a3-31cd-4c18-ade9-983a5fc2aef5")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"Welding Line (Chuyền hàn)"
                ,dataindex:"weldingLine",order: 10,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                          Module.Create(ModuleId.Of(new Guid("30211d98-d550-4b7b-b56b-2b2d75e3089b")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"Note (Mô tả)"
                ,dataindex:"description",order: 11,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),

                           Module.Create(ModuleId.Of(new Guid("61cb7a33-e83b-452d-82cf-412821356338")), moduleCode:"DailyProduction", name:"DailyProduction",entity:"DailyProduction",type:"1",
                         entitysearch:"dailyProduction",displaylabels:"ProductName",searchfields:"ProductName",title:"Type (Loại công đoạn)"
                ,dataindex:"type",order: 12,panel_title:"DailyProduction",database_title:"DailyProductionInfo_List",addNewEntity:"add_new_dailyProduction",entityname:"DailyProduction",recordentityname:"",description:"search",description2:"",
                description3:"",description4:"",description5:"",description6:"",status: true),


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
                    "BirthDate","birthDate",new []{"req: false,pattern:true"},"5",5,"UserInfo","","date","","","","","",true),
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
                    "Name","name",new []{"require: true"},"5",3,"UserInfoAction","actionInfos","string","","","","","",true),


                 Form.Create(FormId.Of(new Guid("74f2d556-4419-44ca-902b-6be0cc8c837f")),formCode:"CompanyInfo",name:"CompanyInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Name",fieldName:"name",rule:new []{"require: true"},span:"5",order:1,entityname:"CompanyInfo",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                 //Form.Create(FormId.Of(new Guid("ba9e5ba3-1cce-440b-9da7-226d2b4c930f")),formCode:"Company",name:"Company",
                 //   moduleCode:"MainContact",entity:"",type:"3",typeDetail:"",entitysearch:"people",displaylabels:"firstName,lastName",searchfields:"firstname,lastname",redirectlabel:"Add New Person",urlredirect:"/people",
                 //   label:"Contact",fieldName:"mainContact",rule:new []{"req: false"},span:"5",order:2,entityname:"Company",recordentityname:"",
                 //   description:"search",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                 Form.Create(FormId.Of(new Guid("ba9e5ba3-1cce-440b-9da7-226d2b4c930f")),formCode:"CompanyInfo",name:"CompanyInfo",
                    moduleCode:"Contact",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Contact",fieldName:"contact",rule:new []{"req: false"},span:"5",order:2,entityname:"CompanyInfo",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                  Form.Create(FormId.Of(new Guid("8164d2cc-6cbd-4a1b-8067-eabfe40478fb")),formCode:"CompanyInfo",name:"CompanyInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Country",fieldName:"country",rule:new []{"req:false"},span:"5",order:3,entityname:"CompanyInfo",recordentityname:"",
                    description:"country",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                   Form.Create(FormId.Of(new Guid("2619409c-1f9a-4e9d-ac2c-1666a31c75e6")),formCode:"CompanyInfo",name:"CompanyInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Phone",fieldName:"phone",rule:new []{"req:false"},span:"5",order:4,entityname:"CompanyInfo",recordentityname:"",
                    description:"phone",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                   Form.Create(FormId.Of(new Guid("80312ae9-7c00-4525-8088-4fce61508c46")),formCode:"CompanyInfo",name:"CompanyInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Email",fieldName:"email",rule:new []{"require:true"},span:"5",order:5,entityname:"CompanyInfo",recordentityname:"",
                    description:"email",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                   Form.Create(FormId.Of(new Guid("db89833a-73d1-422e-a214-e7926f831dfd")),formCode:"CompanyInfo",name:"CompanyInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Website",fieldName:"website",rule:new []{"require:true"},span:"5",order:6,entityname:"CompanyInfo",recordentityname:"",
                    description:"website",description2:"",description3:"",description4:"",description5:"",description6:"",true),



                   Form.Create(FormId.Of(new Guid("6754a777-3349-4a96-ba00-e8046f626848")),formCode:"Product",name:"Product",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"ProductName (Loại khung)",fieldName:"productName",rule:new []{"require:true"},span:"5",order:1,entityname:"Product",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                   Form.Create(FormId.Of(new Guid("844fd9e0-3d15-462c-a2f7-be99458aef45")),formCode:"Product",name:"Product",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"ItemCode 01 (Mã sản phẩm 1)",fieldName:"productCode01",rule:new []{"require:true"},span:"5",order:2,entityname:"Product",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                       Form.Create(FormId.Of(new Guid("bc27d0c7-4865-433d-8a57-3d361d216320")),formCode:"Product",name:"Product",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"ItemCode 02 (Mã sản phẩm 2)",fieldName:"productCode02",rule:new []{"req:false"},span:"5",order:3,entityname:"Product",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                       Form.Create(FormId.Of(new Guid("f087a692-468d-40df-953a-3417b3399088")),formCode:"Product",name:"Product",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Description (Mô tả)",fieldName:"description",rule:new []{"req:false"},span:"5",order:4,entityname:"Product",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                         Form.Create(FormId.Of(new Guid("b797e209-2e07-41d8-93e9-271567fbb7ea")),formCode:"Product",name:"Product",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Process (Công đoạn)",fieldName:"process",rule:new []{"require:true"},span:"5",order:5,entityname:"Product",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                           Form.Create(FormId.Of(new Guid("e53ed240-2e9e-440f-ad07-2fe04d583575")),formCode:"DictionaryInfo",name:"DictionaryInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"DictionaryInfoName (Tên cấu hình)",fieldName:"dictionaryInfoName",rule:new []{"require:true"},span:"5",order:1,entityname:"DictionaryInfo",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                           Form.Create(FormId.Of(new Guid("6e97d48e-e329-4fed-9c1c-ab1169774d7c")),formCode:"DictionaryInfo",name:"DictionaryInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"DictionaryInfoCode (Code cấu hình)",fieldName:"dictionaryInfoCode",rule:new []{"require:true"},span:"5",order:2,entityname:"DictionaryInfo",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                           Form.Create(FormId.Of(new Guid("5e04a045-97a7-4a50-965a-d2e659cc9f6b")),formCode:"DictionaryInfo",name:"DictionaryInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Description (Diễn giải)",fieldName:"description",rule:new []{"req:false"},span:"5",order:3,entityname:"DictionaryInfo",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                            Form.Create(FormId.Of(new Guid("133f53c8-ccb0-4569-87f7-5c97252b3c83")),formCode:"DictionaryInfo",name:"DictionaryInfo",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Process (Loại)",fieldName:"process",rule:new []{"require:true"},span:"5",order:4,entityname:"DictionaryInfo",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                             Form.Create(FormId.Of(new Guid("ae0d93f2-6c05-4322-a477-16f5eace6e6f")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Date (Ngày)",fieldName:"date",rule:new []{"require:true"},span:"5",order:1,entityname:"DailyProduction",recordentityname:"",
                    description:"date",description2:"",description3:"",description4:"",description5:"",description6:"",true),
                             Form.Create(FormId.Of(new Guid("aa160caa-bf9e-446d-9927-4b436aa5ad99")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Type (Loại công đoạn)",fieldName:"type",rule:new []{"require:true"},span:"5",order:2,entityname:"DailyProduction",recordentityname:"",
                    description:"select",description2:"welding,Welding;heattreat,HeatTreat;coating,Coating;assembling,Assembling",description3:"",description4:"",description5:"",description6:"",true),

                             Form.Create(FormId.Of(new Guid("2edc4ebe-dac0-4d2b-9ac0-e1e2460e4356")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"product",displaylabels:"productName",searchfields:"productName",redirectlabel:"",urlredirect:"",
                    label:"Product Id (Id Khung)",fieldName:"productId",rule:new []{"req:false"},span:"5",order:3,entityname:"DailyProduction",recordentityname:"",
                    description:"search",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                             Form.Create(FormId.Of(new Guid("b332569e-75e4-4dd8-a837-b523f0faf597")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"ProductName Not in Master (Tên khung ngoài danh mục)",fieldName:"productName",rule:new []{"req:false"},span:"5",order:4,entityname:"DailyProduction",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),



                             Form.Create(FormId.Of(new Guid("bd638b07-2b6b-4c26-ba29-6db2ea8f7075")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Total Quantity (Tổng số lượng)",fieldName:"totalQuantity",rule:new []{"require:true"},span:"5",order:5,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                             Form.Create(FormId.Of(new Guid("2f0d5978-7c77-4e1a-8b75-7cd6a7f4907d")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"NG Welding/Heat/Coating Qty (Tổng số lượng NG hàn/ Ủ/ Coating)",fieldName:"ngQuantity1",rule:new []{"require:true"},span:"5",order:6,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                             Form.Create(FormId.Of(new Guid("8d608858-f885-444e-8f0a-eb1f9695c2a3")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"NG Reaming Qty (Số lượng Doa NG)",fieldName:"ngQuantity2",rule:new []{"require:true"},span:"5",order:7,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                             Form.Create(FormId.Of(new Guid("aa393c8e-8c04-425f-aa28-de79ee6cbbd4")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Goods Quantity (Số lượng thành phẩm)",fieldName:"goodsQuantity",rule:new []{"require:true"},span:"5",order:8,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                             Form.Create(FormId.Of(new Guid("250d4956-8a21-488f-9cbf-0c90d957c1ce")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"QC Quantity (Số lượng QC)",fieldName:"qcQuantity",rule:new []{"require:true"},span:"5",order:9,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                             Form.Create(FormId.Of(new Guid("6d19a8bf-c943-42f9-b0a5-0c7865d1452c")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Income Quantity (Số lượng còn lại)",fieldName:"incomeQuantity",rule:new []{"require:true"},span:"5",order:10,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),

                                            Form.Create(FormId.Of(new Guid("f0bb29c8-6643-47e5-b6ac-8267e79d2a50")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"ManPower (Số người)",fieldName:"manPower",rule:new []{"require:true"},span:"5",order:11,entityname:"DailyProduction",recordentityname:"",
                    description:"number",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                                            Form.Create(FormId.Of(new Guid("f7e64e29-3881-42ea-ab87-9e80869a7d3b")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Welding Line (Chuyền hàn)",fieldName:"weldingLine",rule:new []{"req:false"},span:"5",order:12,entityname:"DailyProduction",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                                            Form.Create(FormId.Of(new Guid("83b44a52-855c-49f2-b600-4aca697759cc")),formCode:"DailyProduction",name:"DailyProduction",
                    moduleCode:"Name",entity:"",type:"3",typeDetail:"",entitysearch:"",displaylabels:"",searchfields:"",redirectlabel:"",urlredirect:"",
                    label:"Note (Mô tả)",fieldName:"description",rule:new []{"require:true"},span:"5",order:13,entityname:"DailyProduction",recordentityname:"",
                    description:"string",description2:"",description3:"",description4:"",description5:"",description6:"",true),


                                            


                                          
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
