#pragma checksum "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2174723a7af2816b020ad48a3cb0e9ebdcd7aca9"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_1.Pages
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
#line 2 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageAdults")]
    public partial class ManageAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 b-2xldlh82uz>Manage Families</h2>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-2xldlh82uz");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "b-2xldlh82uz");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddAttribute(9, "b-2xldlh82uz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                              NewFamily

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                                                        AddFamily

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "container");
                __builder2.AddAttribute(20, "b-2xldlh82uz");
                __builder2.AddMarkupContent(21, "<h3 style=\"margin-top: 40px\" b-2xldlh82uz>Add Family</h3>\r\n\r\n\r\n                    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddAttribute(24, "b-2xldlh82uz");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddAttribute(27, "style", "margin-top: 19px");
                __builder2.AddAttribute(28, "b-2xldlh82uz");
                __builder2.AddMarkupContent(29, "\r\n                            Street Name: <br b-2xldlh82uz>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                                                    NewFamily.StreetName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewFamily.StreetName = __value, NewFamily.StreetName))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewFamily.StreetName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddAttribute(37, "b-2xldlh82uz");
                __builder2.AddMarkupContent(38, "\r\n                        House Number: <br b-2xldlh82uz>\r\n                        ");
                __Blazor.Assignment_1.Pages.ManageAdults.TypeInference.CreateInputNumber_0(__builder2, 39, 40, 
#nullable restore
#line 32 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                                                  NewFamily.HouseNumber

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewFamily.HouseNumber = __value, NewFamily.HouseNumber)), 42, () => NewFamily.HouseNumber);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n\r\n                    ");
                __builder2.AddMarkupContent(44, "<p style=\"margin-top: 35px\" class=\"actions\" b-2xldlh82uz><button class=\"btn btn-outline-dark\" type=\"submit\" b-2xldlh82uz>Add</button></p>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "RemoveFamily");
            __builder.AddAttribute(48, "style", "margin-top: 30px ");
            __builder.AddAttribute(49, "b-2xldlh82uz");
            __builder.AddMarkupContent(50, "<h3 b-2xldlh82uz>Remove Family</h3>\r\n\r\n                ");
            __builder.OpenElement(51, "form");
            __builder.AddAttribute(52, "b-2xldlh82uz");
            __builder.AddMarkupContent(53, "<label b-2xldlh82uz>Family Id:</label>\r\n                    ");
            __builder.OpenElement(54, "select");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                                   toDeleteFamilyId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => toDeleteFamilyId = __value, toDeleteFamilyId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(57, "b-2xldlh82uz");
#nullable restore
#line 48 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                         foreach (var familiy in Families)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "b-2xldlh82uz");
            __builder.AddContent(60, 
#nullable restore
#line 50 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                                      familiy.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "style", "margin-top: 10px");
            __builder.AddAttribute(64, "class", "btn btn-outline-dark");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                                                                                        DeleteFamily

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "b-2xldlh82uz");
            __builder.AddContent(67, "Remove");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col");
            __builder.AddAttribute(71, "b-2xldlh82uz");
            __builder.OpenElement(72, "form");
            __builder.AddAttribute(73, "b-2xldlh82uz");
            __builder.AddMarkupContent(74, "<label b-2xldlh82uz>Select what do you want to add: </label>\r\n                ");
            __builder.OpenElement(75, "select");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
                               Option

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Option = __value, Option));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(78, "b-2xldlh82uz");
            __builder.OpenElement(79, "option");
            __builder.AddAttribute(80, "b-2xldlh82uz");
            __builder.AddContent(81, "Adult");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "b-2xldlh82uz");
            __builder.AddContent(85, "Child");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "b-2xldlh82uz");
            __builder.AddContent(89, "Pet");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
             if (Option.Equals("Adult"))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Assignment_1.Pages.AddAdult>(90);
            __builder.CloseComponent();
#nullable restore
#line 72 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
            }
            else if (Option.Equals("Child"))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Assignment_1.Pages.AddChild>(91);
            __builder.CloseComponent();
#nullable restore
#line 76 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
            }
            else if (Option.Equals("Pet"))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Assignment_1.Pages.AddPet>(92);
            __builder.CloseComponent();
#nullable restore
#line 80 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Nick\RiderProjects\Assigmnets\Assignment-1\Pages\ManageAdults.razor"
       
    private int toDeleteFamilyId;
    private string Option = "";
    private Family NewFamily = new Family();


    private IList<Family> Families;

    protected override async Task OnInitializedAsync()
    {
        if (FamilyManager.getFamilies() == null)
        {
            Families = new List<Family>();
        }
        else
        {
            Families = FamilyManager.getFamilies();   
        }
    }


    private void DeleteFamily()
    {
        FamilyManager.RemoveFamily(toDeleteFamilyId);
        NavigationManager.NavigateTo("/");
    }

    private void AddFamily()
    {
        NewFamily.Id = Families.Max(t => t.Id) +1;
        NewFamily.Adults = new List<Adult>();
        NewFamily.Children = new List<Child>();
        NewFamily.Pets = new List<Pet>();
        
        FamilyManager.AddFamily(NewFamily);
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITFamilyManager FamilyManager { get; set; }
    }
}
namespace __Blazor.Assignment_1.Pages.ManageAdults
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
