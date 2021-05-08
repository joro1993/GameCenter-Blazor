// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace gamecenter.Client.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Shared\Components\InputImg.razor"
       
    [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; } // used to inform a new file is collected
    [Parameter] public string ImageURL { get; set; }
    private string imageBase64;
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var imagesFiles = e.GetMultipleFiles();
   
        foreach(var imageFile in imagesFiles) 
        {
            var buffer = new byte[imageFile.Size];
            await imageFile.OpenReadStream().ReadAsync(buffer);
            imageBase64 = Convert.ToBase64String(buffer);
            await OnSelectedImage.InvokeAsync(imageBase64);
            ImageURL = null;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
