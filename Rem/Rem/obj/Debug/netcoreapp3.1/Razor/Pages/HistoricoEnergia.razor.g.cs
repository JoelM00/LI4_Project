#pragma checksum "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c82883fd2d1d7b8a3e47472b3f2feece5d9da5f"
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
#line 1 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Rem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\_Imports.razor"
using Rem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
using Rem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/central/{id}/historicoEnergia")]
    public partial class HistoricoEnergia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>HistoricoEnergia</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "id", "date");
            __builder.AddAttribute(3, "type", "date");
            __builder.AddAttribute(4, "placeholder", "YYYY-MM-DD");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                                                                   dataMin

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataMin = __value, dataMin, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "id", "date");
            __builder.AddAttribute(10, "type", "date");
            __builder.AddAttribute(11, "placeholder", "YYYY-MM-DD");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                                                                   dataMax

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataMax = __value, dataMax, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "TipoAtual=");
            __builder.AddContent(17, 
#nullable restore
#line 17 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
              unidade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                  PutHoras

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, " Horas ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                  PutDias

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, " Dias ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                  PutMes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, " Mes ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n<p></p>");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "submit");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                                       MostrarHistorico

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, " Submit ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "<p></p>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
 if (grafico == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.AddMarkupContent(37, "<p><em>Insira Dados..</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
}else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "thead");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<th>Data</th>\r\n");
#nullable restore
#line 32 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                 if (unidade == "horas") 
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                    ");
            __builder.AddMarkupContent(48, "<th>Hora</th>\r\n");
#nullable restore
#line 35 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.AddMarkupContent(50, "<th>Quant</th>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "tbody");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 40 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
             foreach (var c in grafico)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                ");
            __builder.OpenElement(56, "tr");
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 43 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                         c.Data.Year

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " - ");
            __builder.AddContent(61, 
#nullable restore
#line 43 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                                        c.Data.Month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " - ");
            __builder.AddContent(63, 
#nullable restore
#line 43 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                                                        c.Data.Day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 44 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                     if (unidade == "horas") {

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 45 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                         c.Hora

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 46 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 47 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
                         c.Quant

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 49 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 52 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Utilizador\Documents\ne\Uni - 3 ano\2 semestre\LI4\Fase 3\Rem\Rem\Pages\HistoricoEnergia.razor"
       
    public DateTime dataMin { get; set; } = DateTime.Now;
    public DateTime dataMax { get; set; } = DateTime.Now;
    public string unidade { get; set; } = "dias";
    List<GraficoModel> grafico;

    [Parameter]
    public string Id { get; set; }

    protected void PutHoras()
    {
        unidade = "horas";
    }

    protected void PutDias()
    {
        unidade = "dias";
    }

    protected void PutMes()
    {
        unidade = "mes";
    }

    protected async Task MostrarHistorico()
    {
        string sql = "CALL historicoEnergias(" + Id +
            ",'" + dataMin.Year +"-"+ dataMin.Month +"-"+dataMin.Day +
            "','" + dataMax.Year +"-"+ dataMax.Month +"-"+dataMax.Day +
            "','" + unidade + "');";
        grafico = await _data.LoadData<GraficoModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
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
