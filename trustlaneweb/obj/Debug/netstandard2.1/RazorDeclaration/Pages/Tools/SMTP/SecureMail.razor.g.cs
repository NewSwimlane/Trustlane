#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f4c6843b38a91bd4f80b18ef76e8f1bb923c99"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace trustlaneweb.Pages.Tools.SMTP
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
#line 11 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
    public partial class SecureMail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/SMTP/SecureMail.razor"
       
    SfRichTextEditor RichTextEditorObj;
    private List<TreeData> localData = new List<TreeData>()
{
        new TreeData { Id = 1, Name = "Favorites",  HasChild = true, },
        new TreeData { Id = 2, Pid = 1,  Name = "Sales Reports",  Count = 4 },
        new TreeData { Id = 3, Pid = 1, Name = "Sent Items" },
        new TreeData { Id = 4, Pid = 1, Name = "Marketing Reports", Count = 6 },
        new TreeData { Id = 5, HasChild = true, Name = "Andrew Fuller", Expanded = true },
        new TreeData { Id = 6, Pid = 5, Name = "Inbox", Selected = true, Count = 20 },
        new TreeData { Id = 7, Pid = 5, Name = "Drafts", Count = 5 },
        new TreeData { Id = 8, Pid = 5, Name = "Deleted Items" },
        new TreeData { Id = 9, Pid = 5, Name = "Sent Items"  },
        new TreeData { Id = 10, Pid = 5, Name = "Sales Reports", Count = 4 },
        new TreeData { Id = 11, Pid = 5, Name = "Marketing Reports", Count = 6 },
        new TreeData { Id = 12, Pid = 5, Name = "Outbox" },
        new TreeData { Id = 13, Pid = 5, Name = "Junk Email" },
        new TreeData { Id = 14, Pid = 5, Name = "RSS Feed" },
        new TreeData { Id = 15, Pid = 5, Name = "Trash" }
    };
    private List<DataModel> dataSource = new List<DataModel>()
{
        new DataModel { Name= "Selma Tally", Content1="Apology marketing email", Content2="Hello Ananya Singleton", Id = "1", Order = 0},
        new DataModel { Name= "Illa Russo", Content1="Annual conference", Content2="Hi jeani Moresa", Id = "4", Order = 0},
        new DataModel { Name= "Camden Macmellon", Content1="Reference request- Camden hester", Content2="Hello Kerry Best", Id = "3", Order = 0},
        new DataModel { Name= "Garth Owen", Content1="Application for job Title", Content2="Hello Illa Russo", Id = "2", Order = 0},
        new DataModel { Name= "Ursula Patterson", Content1="Programmaer Position Applicant", Content2="Hello Kerry best", Id = "5", Order = 0},
     };
    public class DataModel
    {
        public string Name { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Id { get; set; }
        public int Order { get; set; }
    }
    public class TreeData
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }
        public int Count { get; set; }
        public bool Selected { get; set; }
    }
    private async Task resizeStop()
    {
        await this.RichTextEditorObj.RefreshUI();
    }
    private async Task Created()
    {
        await this.RichTextEditorObj.RefreshUI();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
