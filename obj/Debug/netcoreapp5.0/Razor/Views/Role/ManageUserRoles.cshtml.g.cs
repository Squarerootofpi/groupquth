#pragma checksum "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "151b3a8e3525f68ef86a5e9e71fbf88179907660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_ManageUserRoles), @"mvc.1.0.view", @"/Views/Role/ManageUserRoles.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\squar\source\is-repos\groupauth\Views\_ViewImports.cshtml"
using groupauth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\squar\source\is-repos\groupauth\Views\_ViewImports.cshtml"
using groupauth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\squar\source\is-repos\groupauth\Views\_ViewImports.cshtml"
using groupauth.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\squar\source\is-repos\groupauth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151b3a8e3525f68ef86a5e9e71fbf88179907660", @"/Views/Role/ManageUserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79e756916308ee419a38e949e04f8070b730a6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_ManageUserRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageUserRolesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageUserRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
  
    ViewData["Title"] = "Researcher Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Selected Researcher:</h1>\r\n<table class=\"table table-striped table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Name</td>\r\n");
#nullable restore
#line 12 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
             foreach (IdentityRole role in Model.Roles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 14 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
               Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 15 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
           Write(Model.User.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
           Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
             foreach (IdentityRole role in Model.Roles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151b3a8e3525f68ef86a5e9e71fbf881799076606138", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 702, "\"", 718, 1);
#nullable restore
#line 25 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
WriteAttributeValue("", 710, role.Id, 710, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 785, "\"", 807, 1);
#nullable restore
#line 26 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
WriteAttributeValue("", 793, Model.User.Id, 793, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    <input type=\"hidden\" name=\"addOrRemove\" value=\"false\" hidden />\r\n                    <button type=\"submit\">Remove User as ");
#nullable restore
#line 28 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
                                                    Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151b3a8e3525f68ef86a5e9e71fbf881799076609105", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 1129, "\"", 1145, 1);
#nullable restore
#line 31 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
WriteAttributeValue("", 1137, role.Id, 1137, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1212, "\"", 1234, 1);
#nullable restore
#line 32 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
WriteAttributeValue("", 1220, Model.User.Id, 1220, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    <input type=\"hidden\" name=\"addOrRemove\" value=\"true\" hidden />\r\n                    <button type=\"submit\">Add User as ");
#nullable restore
#line 34 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
                                                 Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\squar\source\is-repos\groupauth\Views\Role\ManageUserRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageUserRolesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
