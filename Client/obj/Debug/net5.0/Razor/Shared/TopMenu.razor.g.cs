#pragma checksum "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbeb6f70528ec77dbe696c53a2a884c70b0aa9f"
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
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Typeahead.BlazoredTypeahead<Product, Product>>(0);
            __builder.AddAttribute(1, "SearchMethod", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Product>>>(
#nullable restore
#line 7 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
                                  SearchProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Product>(
#nullable restore
#line 10 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
                          selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Product>(this, 
#nullable restore
#line 11 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
                                 HandleSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Product>>>(
#nullable restore
#line 12 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
                                      () => selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "placeholder", "Search...");
            __builder.AddAttribute(6, "SelectedTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Product>)((context) => (__builder2) => {
                __builder2.AddContent(7, 
#nullable restore
#line 15 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
         context.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(8, "ResultTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Product>)((context) => (__builder2) => {
                __builder2.AddContent(9, 
#nullable restore
#line 18 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
         context.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(10, "NotFoundTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.String>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        Sorry, there weren\'t any products found.\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "cart");
            __builder.AddAttribute(15, "class", "btn btn-info");
            __builder.AddMarkupContent(16, "<i class=\"oi oi-cart\"></i>\r\n    Cart\r\n    ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "badge badge-pill badge-light");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
                                                GetProductCount()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\TopMenu.razor"
             
    private Product selectedProduct;

    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged;

    }

    public void Dispose()
    {
        CartService.OnChange -= StateHasChanged;
    }

    private int GetProductCount()
    {
        var cart = LocalStorage.GetItem<List<ProductVariant>>("cart");
        return cart != null ? cart.Count : 0;
    }

    private void HandleSearch(Product product)
    {
        if (product == null) return;
        selectedProduct = product;
        NavigationManager.NavigateTo($"product/{selectedProduct.Id}");
    }

    private async Task<IEnumerable<Product>> SearchProduct(string searchText)
    {
        var response = await ProductService.SearchProducts(searchText);
        return response;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
