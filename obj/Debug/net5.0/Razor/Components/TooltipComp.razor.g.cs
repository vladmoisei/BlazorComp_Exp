#pragma checksum "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\Components\TooltipComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c131c01fd2adc1cfe2b7613d1c1043b4fdbb410b"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Components_VM_Ex.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Blazor_Components_VM_Ex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Blazor_Components_VM_Ex.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\_Imports.razor"
using Blazor_Components_VM_Ex.Components;

#line default
#line hidden
#nullable disable
    public partial class TooltipComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tooltip-wrapper");
            __builder.AddAttribute(2, "b-t4bi95nfem");
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "b-t4bi95nfem");
            __builder.AddContent(5, 
#nullable restore
#line 2 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\Components\TooltipComp.razor"
           Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddContent(7, 
#nullable restore
#line 3 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\Components\TooltipComp.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Vlad\source\repos\Blazor_Components_VM_Ex\Components\TooltipComp.razor"
       
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public string Text { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591