#pragma checksum "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb3ffd81b10c67d834ef3b76ebcc4b2ec75ceab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\_ViewImports.cshtml"
using SoproCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\_ViewImports.cshtml"
using SoproCinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb3ffd81b10c67d834ef3b76ebcc4b2ec75ceab", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f699deab87aa62554a41d0e5f23332127940ac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Movie Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex p-2 justify-content-center\">\r\n\r\n    <div class=\"card\">\r\n        <img class=\"card-img-top\" style=\"width: 100%; height: 500px\" src=\"/movie1.jpg\" alt=\"Card image cap\">\r\n        <div class=\"card-body\">\r\n            <h2 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                              Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h6 class=\"card-text\">Release Date: ");
#nullable restore
#line 12 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                           Write(Model.ReleaseDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6 class=\"card-text\">Genre:  \r\n           \r\n");
#nullable restore
#line 15 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
             foreach (var gen in Model.MovieGenres)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"display: inline\"> ");
#nullable restore
#line 17 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                       Write(gen.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</p>\r\n");
#nullable restore
#line 18 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h6>\r\n            \r\n            <h6 class=\"card-text\">Cast: |  \r\n");
#nullable restore
#line 23 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
             foreach (var prs in Model.PersonMovieRoles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"card-text\" style=\"display: inline\"> ");
#nullable restore
#line 25 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                                         Write(prs.Person.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                                                                Write(prs.Person.PersonLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 25 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                                                                                             Write(prs.Role.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</p>\r\n");
#nullable restore
#line 26 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h6>\r\n            <h6 class=\"card-text\">Description: ");
#nullable restore
#line 29 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6 class=\"card-text\">Movie Length: ");
#nullable restore
#line 30 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                           Write(Model.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6 class=\"card-text\">Rating: ");
#nullable restore
#line 31 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                     Write(Model.MovieRatings);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6>IMDB:<a");
            BeginWriteAttribute("href", " href=\"", 1210, "\"", 1232, 1);
#nullable restore
#line 32 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1217, Model.ImdbLink, 1217, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 32 "C:\Users\Viktor\Desktop\.NET DEV\SOPRO CINEMA\SoproCinema\SoproCinema\Views\Movies\Details.cshtml"
                                           Write(Model.ImdbLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\r\n        </div>\r\n        <div class=\"card-footer\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb3ffd81b10c67d834ef3b76ebcc4b2ec75ceab9355", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
