#pragma checksum "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf6d4088ec4ba5b310bf2ebeebd2334cc9e7517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/_ViewImports.cshtml"
using ReactDemo;

#line default
#line hidden
#line 3 "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf6d4088ec4ba5b310bf2ebeebd2334cc9e7517", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7365c36de8d85af4f330dac1a35f2d6f471459c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReactDemo.Models.CommentModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/Home/Index.cshtml"
  
	Layout = null;

#line default
#line hidden
            BeginContext(71, 7, true);
            WriteLiteral("<html>\n");
            EndContext();
            BeginContext(78, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf6d4088ec4ba5b310bf2ebeebd2334cc9e75173478", async() => {
                BeginContext(84, 29, true);
                WriteLiteral("\n\t<title>Hello React</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(120, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(121, 701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf6d4088ec4ba5b310bf2ebeebd2334cc9e75174665", async() => {
                BeginContext(127, 2, true);
                WriteLiteral("\n\t");
                EndContext();
                BeginContext(130, 153, false);
#line 10 "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/Home/Index.cshtml"
Write(Html.React("CommentBox", new
	{
		initialData = Model,
		url = Url.Action("Comments"),
		submitUrl = Url.Action("AddComment"),
		pollInterval = 2000,
	}));

#line default
#line hidden
                EndContext();
                BeginContext(283, 452, true);
                WriteLiteral(@"
	<script crossorigin src=""https://cdnjs.cloudflare.com/ajax/libs/react/16.8.0/umd/react.development.js""></script>
	<script crossorigin src=""https://cdnjs.cloudflare.com/ajax/libs/react-dom/16.8.0/umd/react-dom.development.js""></script>
	<script crossorigin src=""https://cdnjs.cloudflare.com/ajax/libs/prop-types/15.6.0/prop-types.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/remarkable/1.7.1/remarkable.min.js""></script>
	<script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 735, "\"", 774, 1);
#line 21 "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/Home/Index.cshtml"
WriteAttributeValue("", 741, Url.Content("~/js/tutorial.jsx"), 741, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(775, 12, true);
                WriteLiteral("></script>\n\t");
                EndContext();
                BeginContext(788, 26, false);
#line 22 "/Users/hannansaleemilocal/Downloads/React.NET-master/tutorial-code/Views/Home/Index.cshtml"
Write(Html.ReactInitJavaScript());

#line default
#line hidden
                EndContext();
                BeginContext(814, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(822, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReactDemo.Models.CommentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
