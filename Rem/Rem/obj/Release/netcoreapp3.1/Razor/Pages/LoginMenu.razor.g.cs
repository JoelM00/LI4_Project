#pragma checksum "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e26793d4390d60a09d33646ade6f91e796296864"
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
#line 2 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
using Rem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoginMenu")]
    public partial class LoginMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LoginMenu</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
 if (loginState.IsLoggedIn.Equals(false))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h4>Login</h4>\r\n");
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Email: ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "id", "Email");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
                                                         Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, "Pass: ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "id", "Pass");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
                                                       Pass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pass = __value, Pass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "submit");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
                                    InserirUtilizador

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, " Submit ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 21 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
                        () => LogOut()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "LogOut");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 25 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\carlo\OneDrive\Ambiente de Trabalho\Rem\Rem\Pages\LoginMenu.razor"
       

    public string Email;
    public string Pass;

    List<UtilizadorLogin> utilizador;


    private async Task InserirUtilizador()
    {
        string sql = "CALL login('" + Email + "','" + Pass + "')";
        utilizador = await _data.LoadData<UtilizadorLogin, dynamic>(sql, new { }, _config.GetConnectionString("default"));

        if (utilizador != null)
        {
            foreach (var c in utilizador)
            {
                loginState.SetLogin(true, c.Email, c.Password, c.Gestor);
            }
        }
    }

    protected async Task LogOut()
    {
        string sql = "CALL logOut('" + loginState.Username + "');";
        await _data.SaveData(sql, new { }, _config.GetConnectionString("default"));
        loginState.SetLogin(false, "", "", false);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoggedState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAcess _data { get; set; }
    }
}
#pragma warning restore 1591
