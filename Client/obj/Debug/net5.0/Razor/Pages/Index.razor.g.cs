#pragma checksum "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "806f1760b4911c615d12a81bf13a253746fc6eb8"
// <auto-generated/>
#pragma warning disable 1591
namespace E_commerce.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor"
 if (category != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Welcome to the ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor"
                                    category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " section!");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n                ");
            __builder.OpenComponent<E_commerce.Client.Shared.ProductList>(5);
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor"
}
else
 {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "<h1>Welcome to Shop!</h1>");
            }
            ));
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "h1");
                __builder2.AddContent(11, "Welcome back, ");
                __builder2.AddContent(12, 
#nullable restore
#line 20 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor"
                               LocalStorage.GetItemAsString("username")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, "!");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenComponent<E_commerce.Client.Shared.ProductList>(15);
            __builder.CloseComponent();
#nullable restore
#line 24 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor"
 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Pages\Index.razor"
 
    [Parameter]
    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override async Task OnParametersSetAsync()
    {
        await ProductService.LoadProducts(CategoryUrl);

        if (CategoryUrl != null)
        {
            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
        }
        else
        {
            category = null;
        }

        await StatsService.IncrementVisits();
        await StatsService.GetVisits();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStatsService StatsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591