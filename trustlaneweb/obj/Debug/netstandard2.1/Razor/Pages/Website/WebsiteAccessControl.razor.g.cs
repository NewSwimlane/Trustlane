#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Website/WebsiteAccessControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a02e40e9281d1188abc5a52a6265cbae35a120e"
// <auto-generated/>
#pragma warning disable 1591
namespace trustlaneweb.Pages.Website
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Website/WebsiteAccessControl.razor"
using Syncfusion.Blazor.QueryBuilder;

#line default
#line hidden
#nullable disable
    public partial class WebsiteAccessControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Trustlane ACL Editor</h3>\r\n\r\nAge,\r\nResident (drilldown),\r\nCitizen,\r\nID is Self, or delegate of self\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.QueryBuilder.SfQueryBuilder>(4);
            __builder.AddAttribute(5, "Width", "70%");
            __builder.AddAttribute(6, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Website/WebsiteAccessControl.razor"
                                             DataSource

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderRule>(9);
                __builder2.AddAttribute(10, "Condition", "and");
                __builder2.AddAttribute(11, "Rules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Syncfusion.Blazor.QueryBuilder.RuleModel>>(
#nullable restore
#line 12 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Website/WebsiteAccessControl.razor"
                                                  Rules

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumns>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(16);
                    __builder3.AddAttribute(17, "Field", "CustomerId");
                    __builder3.AddAttribute(18, "Label", "MyUserID");
                    __builder3.AddAttribute(19, "Type", "number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(21);
                    __builder3.AddAttribute(22, "Field", "EmployeeId");
                    __builder3.AddAttribute(23, "Label", "ActualUserID");
                    __builder3.AddAttribute(24, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(26);
                    __builder3.AddAttribute(27, "Field", "Verified");
                    __builder3.AddAttribute(28, "Label", "Verified");
                    __builder3.AddAttribute(29, "Type", "boolean");
                    __builder3.AddAttribute(30, "Values", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Website/WebsiteAccessControl.razor"
                                                                                         Values

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(32);
                    __builder3.AddAttribute(33, "Field", "ShipName");
                    __builder3.AddAttribute(34, "Label", "ShipName");
                    __builder3.AddAttribute(35, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(37);
                    __builder3.AddAttribute(38, "Field", "OrderDate");
                    __builder3.AddAttribute(39, "Label", "OrderDate");
                    __builder3.AddAttribute(40, "Type", "date");
                    __builder3.AddAttribute(41, "Format", "dd/MM/yyyy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(43);
                    __builder3.AddAttribute(44, "Field", "ShipCountry");
                    __builder3.AddAttribute(45, "Label", "ShipCountry");
                    __builder3.AddAttribute(46, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.QueryBuilder.QueryBuilderColumn>(48);
                    __builder3.AddAttribute(49, "Field", "ShipAddress");
                    __builder3.AddAttribute(50, "Label", "ShipAddress");
                    __builder3.AddAttribute(51, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n");
            __builder.AddMarkupContent(56, "<style>\r\n    .e-query-builder {\r\n        margin: 0 auto;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Website/WebsiteAccessControl.razor"
      
    List<RuleModel> Rules = new List<RuleModel>()
    {
            new RuleModel { Label="CustomerId", Field="CustomerId", Type="number", Operator="equal", Value = 1001 },
            new RuleModel { Label="EmployeeId", Field="EmployeeId", Type="string", Operator="equal", Value = "FLKIN" }
     };

    public List<string> Values = new List<string> { "True", "False" };
    public List<Orders> DataSource { get; set; }
    protected override void OnInitialized()
    {
        DataSource = Orders.GetAllRecords();
    }

    public class Orders
    {
        public Orders()
        {

        }
        public Orders(int OrderID, string CustomerId, int EmployeeId, decimal Freight, bool Verified, DateTime OrderDate, string ShipCity, string ShipName, string ShipCountry, DateTime ShippedDate, string ShipAddress)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.ShipCity = ShipCity;
            this.Verified = Verified;
            this.OrderDate = OrderDate;
            this.ShipName = ShipName;
            this.ShipCountry = ShipCountry;
            this.ShippedDate = ShippedDate;
            this.ShipAddress = ShipAddress;
        }
        public static List<Orders> GetAllRecords()
        {
            List<Orders> orders = new List<Orders>();
            int code = 10000;
            for (int i = 1; i < 15; i++)
            {
                orders.Add(new Orders(code + 1, "ALFKI", i + 0, 2.32m * i, false, new DateTime(1991, 05, 15), "Berlin", "Simons bistro", "Denmark", new DateTime(1996, 7, 16), "Kirchgasse 6"));
                orders.Add(new Orders(code + 2, "ANATR", i + 2, 3.32m * i, true, new DateTime(1990, 04, 04), "Madrid", "Queen Cozinha", "Brazil", new DateTime(1996, 9, 11), "Avda. Azteca 123"));
                orders.Add(new Orders(code + 3, "ANTON", i + 1, 4.35m * i, true, new DateTime(1957, 11, 30), "Cholchester", "Frankenversand", "Germany", new DateTime(1996, 10, 7), "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"));
                orders.Add(new Orders(code + 4, "BLONP", i + 3, 5.38m * i, false, new DateTime(1930, 10, 22), "Marseille", "Ernst Handel", "Austria", new DateTime(1996, 12, 30), "Magazinweg 7"));
                orders.Add(new Orders(code + 5, "BOLID", i + 4, 6.35m * i, true, new DateTime(1953, 02, 18), "Tsawassen", "Hanari Carnes", "Switzerland", new DateTime(1997, 12, 3), "1029 - 12th Ave. S."));
                code += 5;
            }
            return orders;
        }

        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public decimal? Freight { get; set; }
        public string ShipCity { get; set; }
        public bool Verified { get; set; }
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public DateTime ShippedDate { get; set; }
        public string ShipAddress { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
