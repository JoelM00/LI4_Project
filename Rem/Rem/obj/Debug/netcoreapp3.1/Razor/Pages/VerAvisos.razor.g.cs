#pragma checksum "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9586550c251d65eb7690de7eb7efd9057ee7d2f0"
// <auto-generated/>
#pragma warning disable 1591
namespace Rem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Rem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\_Imports.razor"
using Rem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
using Rem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/central/{id}/avisos")]
    public partial class VerAvisos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>VerAvisos</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "id", "date");
            __builder.AddAttribute(3, "type", "date");
            __builder.AddAttribute(4, "placeholder", "YYYY-MM-DD");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                                                                   dataMin

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataMin = __value, dataMin, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "submit");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                                MostrarAvisos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, " Submit ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 17 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
 if (avisos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<p><em>Insira Dados..</em></p>\r\n");
#nullable restore
#line 20 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<thead>\r\n            <tr>\r\n                <th>Mensagem</th>\r\n                <th>Data</th>\r\n                <th>Central</th>\r\n                <th>Nome</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 33 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
             foreach (var c in avisos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                       ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                            c.Mensagem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                             c.Data.Year

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " - ");
            __builder.AddContent(31, 
#nullable restore
#line 37 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                                            c.Data.Month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " - ");
            __builder.AddContent(33, 
#nullable restore
#line 37 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                                                            c.Data.Day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 38 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                             c.Central

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 39 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
                             c.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 41 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 44 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\VerAvisos.razor"
       
    public DateTime dataMin { get; set; }
    List<AvisosModel> avisos;

    [Parameter]
    public string Id { get; set; }

    protected async Task MostrarAvisos()
    {
        string sql = "CALL verAvisos(" + Id +
            ",'" + dataMin.Year + "-" + dataMin.Month + "-" + dataMin.Day + "');";
            avisos = await _data.LoadData<AvisosModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoggedState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAcess _data { get; set; }
    }
}
#pragma warning restore 1591