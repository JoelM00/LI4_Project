// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\AdicionarCentral.razor"
using Rem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\AdicionarCentral.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\AdicionarCentral.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapaCentral/AdicionarCentral")]
    public partial class AdicionarCentral : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\AdicionarCentral.razor"
       

    private AddCentralModel newCentral = new AddCentralModel();

    private async Task InserirCentral()
    {
        string sql = "CALL adicionarCentral('" + newCentral.Estado + "',"
                                               + newCentral.Motores + ",'"
                                               + newCentral.Nome + "','"
                                               + newCentral.Tipo + "',"
                                               + newCentral.Inauguracao + ","
                                               + newCentral.Empresa + ","
                                               + newCentral.CoordenadaX + ","
                                               + newCentral.CoordenadaY + ",'"
                                               + newCentral.Endereco + "',"
                                               + newCentral.MaxDiario + ","
                                               + newCentral.MinDiario + ",'"
                                               + loginState.Username + "')";

        await _data.SaveData(sql, new { }, _config.GetConnectionString("default"));
        NavManager.NavigateTo("/mapaCentral");
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
