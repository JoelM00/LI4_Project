#pragma checksum "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c160253c9c51eb3c50fee9bc4777dc3aee65c5b1"
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
#line 1 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Rem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\_Imports.razor"
using Rem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
using Rem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/verEmpresas")]
    public partial class VerEmpresas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Empresas</h3>\r\n");
#nullable restore
#line 13 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
 if (empresas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th>ID</th>
                <th>Nome</th>
                <th>Descricao</th>
                <th>Sede</th>
                <th>Contacto</th>
                <th>CEO</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 31 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
             foreach (var c in empresas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
                     c.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
                     c.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 36 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
                     c.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
                     c.Sede

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 38 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
                     c.Contacto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 39 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
                     c.Ceo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 41 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 44 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Joel\Documents\GitHub\LI4\Rem\Rem\Pages\VerEmpresas.razor"
       

    List<VerEmpresaModel> empresas;


    protected override async Task OnInitializedAsync()
    {
        string sql = "CALL verEmpresas()";
        empresas = await _data.LoadData<VerEmpresaModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoggedState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAcess _data { get; set; }
    }
}
#pragma warning restore 1591