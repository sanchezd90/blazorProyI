#pragma checksum "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5995e9db6ccd64f6a9387a3f01b422e89aa108"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorProyI.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using blazorProyI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using blazorProyI.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/_Imports.razor"
using blazorProyI.Shared.Entity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actividad2")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "img");
            __builder.AddAttribute(3, "src", 
#nullable restore
#line 3 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor"
               Landscape1.LandscapeImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "class", "img-fluid");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "h5");
            __builder.AddAttribute(7, "class", "text-center");
            __builder.AddMarkupContent(8, "\r\n        Tipo de paisaje: ");
            __builder.AddContent(9, 
#nullable restore
#line 5 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor"
                          Landscape1.LandscapeType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "blockquote");
            __builder.AddAttribute(12, "class", "blockquote text-center");
            __builder.AddMarkupContent(13, "\r\n        Color: ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "mp-0");
            __builder.AddContent(16, 
#nullable restore
#line 8 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor"
                                Landscape1.LandscapeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        Mood: ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "mp-0");
            __builder.AddContent(20, 
#nullable restore
#line 9 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor"
                               Landscape1.LandscapeMood

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "footer");
            __builder.AddAttribute(23, "class", "blockquote");
            __builder.AddContent(24, 
#nullable restore
#line 11 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor"
             Landscape1.PublicationDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/Counter.razor"
      
    private Landscape GetLandscape(){
        return new Landscape(){
            LandscapeType = "Montaña",
            LandscapeColor = "Verde",
            LandscapeMood = "Triste",
            LandscapeImage = "/images/img1.jpg",
            PublicationDate = new DateTime(2021,09,20)
        };
    }

    public Landscape Landscape1{
        get{return GetLandscape();}
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591