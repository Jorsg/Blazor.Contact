// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Contacts.Practic.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Blazor.Contacts.Practic.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Blazor.Contacts.Practic.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Blazor.Contacts.Practic.Shared.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\Pages\FetchData.razor"
using Blazor.Contacts.Practic.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Repos\repos\Blazor.Contacts.Practic\Blazor.Contacts.Practic\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
