#pragma checksum "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bee1553276aa4595dd51fbd1f89ddf1754e5b0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SinavEkrani), @"mvc.1.0.view", @"/Views/Home/SinavEkrani.cshtml")]
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
#line 1 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bee1553276aa4595dd51fbd1f89ddf1754e5b0c", @"/Views/Home/SinavEkrani.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SinavEkrani : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sonuc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
  
    ViewData["Title"] = "SinavEkrani";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"  justify-content-center mt-4\">\r\n\r\n    <h4 class=\"border blockquote text-center p-4 \"> ");
#nullable restore
#line 9 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                               Write(Model.Sinav.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>\r\n<div class=\"row mt-3\">\r\n    <div class=\"col-md-12\">\r\n        <h5 class=\"border blockquote text-center p-4 \"> ");
#nullable restore
#line 13 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                   Write(Model.Sinav.Text2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bee1553276aa4595dd51fbd1f89ddf1754e5b0c4971", async() => {
                WriteLiteral("\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-md-12\">\r\n            <p class=\"border blockquote text-center p-4 \">\r\n                ");
#nullable restore
#line 20 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
           Write(Model.Sinav.Question1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </p>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options"" id=""option1"" value=""b11"" />
            <label class=""btn border btn-block"" id=""b11"" for=""option1"">");
#nullable restore
#line 27 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question1Answers1.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check btn-block\" name=\"options\" id=\"option2\" value=\"b12\" />\r\n            <label class=\"btn border btn-block\" id=\"b12\" for=\"option2\">");
#nullable restore
#line 31 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question1Answers2.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options"" id=""option3"" value=""b13"" />
            <label class=""btn border btn-block "" id=""b13"" for=""option3"">");
#nullable restore
#line 37 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question1Answers3.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check \" name=\"options\" id=\"option4\" value=\"b14\" />\r\n            <label class=\"btn border btn-block\" id=\"b14\" for=\"option4\">");
#nullable restore
#line 41 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question1Answers4.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-md-12\">\r\n            <p class=\"border blockquote text-center p-4 \">\r\n                ");
#nullable restore
#line 47 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
           Write(Model.Sinav.Question2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </p>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options1"" id=""option5"" value=""b21"" />
            <label class=""btn border btn-block"" id=""b21"" for=""option5"">");
#nullable restore
#line 54 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question2Answers1.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check btn-block\" name=\"options1\" id=\"option6\" value=\"b22\" />\r\n            <label class=\"btn border btn-block\" id=\"b22\" for=\"option6\">");
#nullable restore
#line 58 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question2Answers2.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options1"" id=""option7"" value=""b23"" />
            <label class=""btn border btn-block "" id=""b23"" for=""option7"">");
#nullable restore
#line 64 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question2Answers3.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check \" name=\"options1\" id=\"option8\" value=\"b24\" />\r\n            <label class=\"btn border btn-block\" id=\"b24\" for=\"option8\">");
#nullable restore
#line 68 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question2Answers4.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-md-12\">\r\n            <p class=\"border blockquote text-center p-4 \">\r\n                ");
#nullable restore
#line 74 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
           Write(Model.Sinav.Question1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </p>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options2"" id=""option9"" value=""b31"" />
            <label class=""btn border btn-block"" id=""b31"" for=""option9"">");
#nullable restore
#line 81 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                  Write(Model.Sinav.Question3Answers1.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check btn-block\" name=\"options2\" id=\"option10\" value=\"b32\" />\r\n            <label class=\"btn border btn-block\" id=\"b32\" for=\"option10\">");
#nullable restore
#line 85 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question3Answers2.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options2"" id=""option11"" value=""b33"" />
            <label class=""btn border btn-block "" id=""b33"" for=""option11"">");
#nullable restore
#line 91 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                    Write(Model.Sinav.Question3Answers3.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check \" name=\"options2\" id=\"option12\" value=\"b34\" />\r\n            <label class=\"btn border btn-block\" id=\"b34\" for=\"option12\">");
#nullable restore
#line 95 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question3Answers4.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-md-12\">\r\n            <p class=\"border blockquote text-center p-4 \">\r\n                ");
#nullable restore
#line 101 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
           Write(Model.Sinav.Question4);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </p>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options3"" id=""option13"" value=""b41"" />
            <label class=""btn border btn-block"" id=""b41"" for=""option13"">");
#nullable restore
#line 108 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question4Answers1.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check btn-block\" name=\"options3\" id=\"option14\" value=\"b42\" />\r\n            <label class=\"btn border btn-block\" id=\"b42\" for=\"option14\">");
#nullable restore
#line 112 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question4Answers2.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col-md-6 "">
            <input type=""radio"" class=""btn-check btn-block"" name=""options3"" id=""option15"" value=""b43"" />
            <label class=""btn border btn-block "" id=""b43"" for=""option15"">");
#nullable restore
#line 118 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                    Write(Model.Sinav.Question4Answers3.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <input type=\"radio\" class=\"btn-check \" name=\"options3\" id=\"option16\" value=\"b44\" />\r\n            <label class=\"btn border btn-block\" id=\"b44\" for=\"option16\">");
#nullable restore
#line 122 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                                                                   Write(Model.Sinav.Question4Answers4.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n    </div>\r\n    <button id=\"gonder\">GÖNDER</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 129 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Kirmizi1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'red\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 132 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Yesil1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'green\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 135 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Yesil2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'green\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 138 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Kirmizi2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'red\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 141 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Yesil3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'green\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 144 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Kirmizi3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'red\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 147 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Yesil4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'green\';\r\n</script>\r\n<script>\r\n    document.getElementById(\'");
#nullable restore
#line 150 "C:\Users\DeepBlue\Desktop\Github\AspCoreAntrenman\Proje23\WebUI\Views\Home\SinavEkrani.cshtml"
                        Write(Model.Kirmizi4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style.backgroundColor = \'red\';\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextModel> Html { get; private set; }
    }
}
#pragma warning restore 1591