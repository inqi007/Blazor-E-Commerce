// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\inqiyadpatwary\source\repos\Ecommerce\E-commerce\Client\Shared\ProductList.razor"
       
    //[Parameter]
    //public int? CategoryId { get; set; } = null;

    protected override void OnInitialized()
    {
        //await ProductService.LoadProducts();
        ProductService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        ProductService.OnChange -= StateHasChanged;
    }

    private string GetPriceText(Product product)
    {
        var variants = product.Variants;
        if (variants.Count == 0)
        {
            return string.Empty;
        }
        else if (variants.Count == 1)
        {
            return $"${variants[0].Price}";
        }
        decimal minPrice = variants.Min(v => v.Price);
        return $"Starting at ${minPrice}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591