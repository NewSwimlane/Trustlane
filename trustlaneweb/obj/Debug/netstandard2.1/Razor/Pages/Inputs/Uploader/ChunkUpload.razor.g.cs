#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Inputs/Uploader/ChunkUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a121a87baab968b7f53b892d18f58715d6e83b00"
// <auto-generated/>
#pragma warning disable 1591
namespace trustlaneweb.Pages.Inputs.Uploader
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
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Inputs/Uploader/ChunkUpload.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/File-Upload/Chunk-Upload")]
    public partial class ChunkUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "control_wrapper");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(6);
            __builder.AddAttribute(7, "ID", "UploadFiles");
            __builder.AddAttribute(8, "DropArea", ".control-fluid");
            __builder.AddAttribute(9, "MaxFileSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Inputs/Uploader/ChunkUpload.razor"
                                                                           104857600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.UploaderAsyncSettings>(12);
                __builder2.AddAttribute(13, "SaveUrl", "https://aspnetmvc.syncfusion.com/services/api/uploadbox/Save");
                __builder2.AddAttribute(14, "RemoveUrl", "https://aspnetmvc.syncfusion.com/services/api/uploadbox/Remove");
                __builder2.AddAttribute(15, "ChunkSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 8 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Inputs/Uploader/ChunkUpload.razor"
                                                                                                                                                                                               500000

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.AddMarkupContent(20, "<style>\r\n    .control_wrapper {\r\n        width: 350px;\r\n        margin: 0 auto;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
