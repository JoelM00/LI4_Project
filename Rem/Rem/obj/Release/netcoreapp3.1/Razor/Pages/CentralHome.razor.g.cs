#pragma checksum "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd7bce951d9fc781592a88b7c9febda2fe53644"
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
#line 3 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
using Rem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/central/{Id}")]
    public partial class CentralHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Central Home</h3>\r\n");
#nullable restore
#line 13 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
 if (centrais == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
     foreach (var c in centrais)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "ul");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "li");
            __builder.AddContent(7, "Nome: ");
            __builder.AddContent(8, 
#nullable restore
#line 22 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                       c.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "li");
            __builder.AddContent(11, "Tipo: ");
            __builder.AddContent(12, 
#nullable restore
#line 23 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                       c.Tipo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "li");
            __builder.AddContent(15, "Inauguracao: ");
            __builder.AddContent(16, 
#nullable restore
#line 24 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                              c.Inauguracao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "li");
            __builder.AddContent(19, "Estado: ");
            __builder.AddContent(20, 
#nullable restore
#line 25 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                         c.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "li");
            __builder.AddContent(23, "Motores: ");
            __builder.AddContent(24, 
#nullable restore
#line 26 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                          c.Motorers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "li");
            __builder.AddContent(27, "Valor: ");
            __builder.AddContent(28, 
#nullable restore
#line 27 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                        c.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "li");
            __builder.AddContent(31, "Maximo Diario: ");
            __builder.AddContent(32, 
#nullable restore
#line 28 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                c.MaximoDiario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "li");
            __builder.AddContent(35, "Minimo Diario: ");
            __builder.AddContent(36, 
#nullable restore
#line 29 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                c.MinimoDiario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "li");
            __builder.AddContent(39, "UltimaAtividade: ");
            __builder.AddContent(40, 
#nullable restore
#line 30 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                  c.UltimaAtividade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "li");
            __builder.AddContent(43, "Gestor: ");
            __builder.AddContent(44, 
#nullable restore
#line 31 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                         c.Gestor_Utilizador_email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "li");
            __builder.AddContent(47, "Empresa: ");
            __builder.AddContent(48, 
#nullable restore
#line 32 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                          c.EmpresaNome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "li");
            __builder.AddContent(51, "CEO: ");
            __builder.AddContent(52, 
#nullable restore
#line 33 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                      c.Ceo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "li");
            __builder.AddContent(55, "Sede: ");
            __builder.AddContent(56, 
#nullable restore
#line 34 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                       c.Sede

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "li");
            __builder.AddContent(59, "Contacto: ");
            __builder.AddContent(60, 
#nullable restore
#line 35 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                           c.Contacto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "li");
            __builder.AddContent(63, "Descricao:");
            __builder.AddContent(64, 
#nullable restore
#line 36 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                           c.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "li");
            __builder.AddContent(67, "X: ");
            __builder.AddContent(68, 
#nullable restore
#line 37 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                    c.CoordenadaX

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "li");
            __builder.AddContent(71, "Y: ");
            __builder.AddContent(72, 
#nullable restore
#line 38 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                    c.CoordenadaY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "li");
            __builder.AddContent(75, "Endereco: ");
            __builder.AddContent(76, 
#nullable restore
#line 39 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                           c.Endereco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "p");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                               () => HistoricoEnergia()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, "HistoricoEnergia");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                            () => CondicoesClimaticas()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "CondicoesClimaticas");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 43 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
         if (loginState.IsLoggedIn == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "            ");
            __builder.OpenElement(89, "p");
            __builder.AddMarkupContent(90, "\r\n            if (!avisosAtivados)\r\n            {");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                 () => QueroAvisos()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(93, "Ativar Avisos");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            }\r\n            else\r\n            {\r\n               ");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                   () => NaoQueroAvisos()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(97, "Desativar Avisos");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            }\r\n            ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                () => VerAvisos()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(101, "VerAvisos");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 55 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"

            if (c.Gestor_Utilizador_email == loginState.Username)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                ");
            __builder.OpenElement(105, "p");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                       () => AdicionarAviso()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(108, "AdicionarAviso");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.OpenElement(110, "button");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                    () => MudarEstado()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(112, "MudarEstado");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.OpenElement(114, "button");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
                                    () => RemoverCentral()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(116, "RemoverCentral");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 61 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\CentralHome.razor"
       

    List<CentralHomeModel> centrais;
    List<BooleanModel> booleanModelos;
    bool avisosAtivados = false;

    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        string sql = "centralInfo(" + Id + ")";

        centrais = await _data.LoadData<CentralHomeModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));

        string sql2 = "CALL verificaAviso(" + Id + ",'" + loginState.Username + "')";
        booleanModelos = await _data.LoadData<BooleanModel, dynamic>(sql2, new { }, _config.GetConnectionString("default"));
        foreach (var i in booleanModelos)
        {
            if (i.BooleanM == true) avisosAtivados = true;
        }
    }

    protected async Task QueroAvisos()
    {
        string sql = "CALL queroAvisos('" + loginState.Username + "'," + Id + ")";
        await _data.SaveData(sql, new { }, _config.GetConnectionString("default"));
        avisosAtivados = true;
    }

    protected async Task NaoQueroAvisos()
    {
        string sql = "CALL naoQueroAviso(" + Id + ",'" + loginState.Username + "')";
        await _data.SaveData(sql, new { }, _config.GetConnectionString("default"));
        avisosAtivados = false;
    }

    protected void RemoverCentral()
    {
        NavManager.NavigateTo("/central/" + Id + "/remover");
    }
    protected void CondicoesClimaticas()
    {
        NavManager.NavigateTo("/central/" + Id + "/condicoesClimaticas");
    }
    protected void HistoricoEnergia()
    {
        NavManager.NavigateTo("/central/" + Id + "/historicoEnergia");
    }

    protected void VerAvisos()
    {
        NavManager.NavigateTo("/central/" + Id + "/avisos");
    }

    protected void AdicionarAviso()
    {
        NavManager.NavigateTo("/central/" + Id + "/AdicionarAviso");
    }

    protected void MudarEstado()
    {
        NavManager.NavigateTo("/central/" + Id +"/MudarEstado");
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