#pragma checksum "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e373f4b5b02e32d1a1744c15a9eed54b4e5a16"
// <auto-generated/>
#pragma warning disable 1591
namespace E_commerce.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using E_commerce.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "<span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2137916\">brief survey</a></span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
