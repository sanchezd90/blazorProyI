#pragma checksum "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "853c722ea7f257a43a7d3bfe2c1036859ed04992"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/actividad3")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck mb-3");
#nullable restore
#line 4 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
         foreach (var landscape in GetLandscapes())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 7 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
                       landscape.LandscapeImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "class", "img-fluid");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "text-center");
            __builder.AddMarkupContent(12, "\r\n                Tipo de paisaje: ");
            __builder.AddContent(13, 
#nullable restore
#line 9 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
                                  landscape.LandscapeType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "blockquote");
            __builder.AddAttribute(16, "class", "blockquote");
            __builder.AddMarkupContent(17, "\r\n                Color: ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "mp-0");
            __builder.AddContent(20, 
#nullable restore
#line 12 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
                                        landscape.LandscapeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                Ánimo: ");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "mp-0");
            __builder.AddContent(24, 
#nullable restore
#line 13 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
                                        landscape.LandscapeMood

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "footer");
            __builder.AddAttribute(27, "class", "blockquote");
            __builder.AddContent(28, 
#nullable restore
#line 15 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
                     landscape.PublicationDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/danielsanchez/Documents/MisionTIC/ProysCicloIII/blazorProyI/Client/Pages/FetchData.razor"
      
    private List<Landscape> GetLandscapes(){
        return new List<Landscape>{
            new Landscape()
            {
                LandscapeType = "Montaña",LandscapeColor = "Verde",LandscapeMood = "Triste",LandscapeImage = "/images/img1.jpg",PublicationDate = new DateTime(2021,09,20)
            },
            new Landscape()
            {
                LandscapeType = "Jardín",LandscapeColor = "Verde",LandscapeMood = "Triste",LandscapeImage = "/images/img2.jpg",PublicationDate = new DateTime(2021,09,19)
            },
            new Landscape()
            {
                LandscapeType = "Bosque",LandscapeColor = "Verde",LandscapeMood = "Neutro",LandscapeImage = "/images/img3.jpg",PublicationDate = new DateTime(2021,09,18)
            }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591