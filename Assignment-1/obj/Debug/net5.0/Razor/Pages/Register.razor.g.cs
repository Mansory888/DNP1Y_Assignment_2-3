#pragma checksum "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d2157a32dd3317b8c85140b8c200304a6709a8a"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\_Imports.razor"
using Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "body");
                __builder2.AddAttribute(3, "b-ynz2b7y80n");
                __builder2.AddMarkupContent(4, "<h2 style=\"text-align: center\" b-ynz2b7y80n>Register Form</h2>\r\n\r\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "BigBox");
                __builder2.AddAttribute(7, "b-ynz2b7y80n");
                __builder2.OpenElement(8, "form");
                __builder2.AddAttribute(9, "b-ynz2b7y80n");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.AddAttribute(12, "b-ynz2b7y80n");
                __builder2.AddMarkupContent(13, "<label for=\"uname\" b-ynz2b7y80n><b b-ynz2b7y80n>Username</b></label>\r\n                    ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "placeholder", "Enter Username");
                __builder2.AddAttribute(17, "name", "uname");
                __builder2.AddAttribute(18, "required");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor"
                                                                                              username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(21, "b-ynz2b7y80n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(23, "<label for=\"psw\" b-ynz2b7y80n><b b-ynz2b7y80n>Password</b></label>\r\n                    ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "placeholder", "Enter Password");
                __builder2.AddAttribute(27, "name", "psw");
                __builder2.AddAttribute(28, "required");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor"
                                                                                                password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(31, "b-ynz2b7y80n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    \r\n                    ");
                __builder2.AddMarkupContent(33, "<label style=\"margin-top:20px\" b-ynz2b7y80n><b b-ynz2b7y80n>Birth Year</b></label>\r\n                    ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "number");
                __builder2.AddAttribute(36, "style", "margin-left: 10px");
                __builder2.AddAttribute(37, "required");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor"
                                                                                 BirthYear

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BirthYear = __value, BirthYear, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(40, "b-ynz2b7y80n");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n\r\n            ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor"
                              RegisterUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "b-ynz2b7y80n");
                __builder2.AddContent(45, "Register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            \r\n            ");
                __builder2.AddMarkupContent(47, "<a href=\"/login\" b-ynz2b7y80n> Go back </a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\Register.razor"
       
    private string username;
    private string password;
    private int BirthYear;
    private string errorMessage;


    public async Task RegisterUser()
    {
       await UserInterface.AddUser(new User()
        {
            UserName = username,
            BirthYear = BirthYear,
            pass = password,
            SecurityLevel = 1
        });
        NavigationManager.NavigateTo("/login");
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITUserInterface UserInterface { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591