#pragma checksum "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Shared\Components\GamesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5627b69561fe920e9ecc79ef52b475e98cc20be6"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class GamesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "games-container");
            __Blazor.gamecenter.Client.Shared.Components.GamesList.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 4 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Shared\Components\GamesList.razor"
                   Games

#line default
#line hidden
#nullable disable
            , 4, (game) => (__builder2) => {
                __builder2.OpenComponent<gamecenter.Client.Shared.Components.IndividualGame>(5);
                __builder2.AddAttribute(6, "Game", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<gamecenter.Shared.Models.Game>(
#nullable restore
#line 6 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Shared\Components\GamesList.razor"
                              game

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "DeleteGame", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<gamecenter.Shared.Models.Game>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<gamecenter.Shared.Models.Game>(this, 
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Shared\Components\GamesList.razor"
                            DeleteGame

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Shared\Components\GamesList.razor"
       
    [Parameter] public List<Game> Games { get; set; }  

    private async Task DeleteGame(Game game) 
    {
        var confirmed = await js.Confirm($"Are you sure you want to delete {game.Title}");
        if(confirmed) 
        {
            Games.Remove(game);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.gamecenter.Client.Shared.Components.GamesList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::gamecenter.Client.Shared.Components.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "ElementTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
