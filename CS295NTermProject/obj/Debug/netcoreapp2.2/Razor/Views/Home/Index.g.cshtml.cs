#pragma checksum "D:\295N\CS295NTermProject\CS295NTermProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dacf5842880cf0ea4902ea27d13649770a1cde1"
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
#line 1 "D:\295N\CS295NTermProject\CS295NTermProject\Views\_ViewImports.cshtml"
using CS295NTermProject;

#line default
#line hidden
#line 2 "D:\295N\CS295NTermProject\CS295NTermProject\Views\_ViewImports.cshtml"
using CS295NTermProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dacf5842880cf0ea4902ea27d13649770a1cde1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542bc6d1075306011d9c365735a1e66b700475cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/files/images/pianofrontpage.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("front-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/frontpage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\295N\CS295NTermProject\CS295NTermProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(40, 33, true);
            WriteLiteral("\r\n<div class=\"img-overlay\">\r\n    ");
            EndContext();
            BeginContext(73, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2dacf5842880cf0ea4902ea27d13649770a1cde14772", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 13150, true);
            WriteLiteral(@"
    <div class=""project-overlay""></div>
    <div class=""title-overlay"">
        <div class=""container py-2"">
            <div class=""center"">
                <img id=""big-logo"" src=""/files/images/smmlogo.svg"" width=""554"" height=""114"" class="""" alt="""">
            </div>
        </div>
        <div class=""container py-2"">
            <h3 class=""text-center font-italic font-weight-normal text-light"">High Quality • Low Cost • Royalty Free</h3>
        </div>
        <div class=""container py-2"">
            <div class=""text-center""><a class=""btn btn-lg btn-primary"" href=""/Home/Music"">Find Music</a></div>
        </div>
    </div>
</div>



<section id=""start"">
    <div class=""container text-center"">
        <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ac turpis egestas sed tempus urna et pharetra pharetra massa. Ultrices dui sapien eget mi proin sed. Pharetra convallis posuere morbi leo. Faucibus a");
            WriteLiteral(@" pellentesque sit amet porttitor. Platea dictumst vestibulum rhoncus est pellentesque elit ullamcorper dignissim. Aenean sed adipiscing diam donec adipiscing tristique risus nec feugiat. Tempor commodo ullamcorper a lacus vestibulum sed arcu. Vestibulum lorem sed risus ultricies tristique nulla aliquet enim tortor. Scelerisque eu ultrices vitae auctor eu augue. Dolor magna eget est lorem ipsum.

            Fames ac turpis egestas sed tempus. Mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor. Massa vitae tortor condimentum lacinia quis vel eros. Viverra vitae congue eu consequat ac felis donec et. Vitae congue mauris rhoncus aenean vel elit scelerisque. Gravida arcu ac tortor dignissim convallis. Facilisi cras fermentum odio eu. Vitae turpis massa sed elementum tempus egestas sed sed risus. Elementum integer enim neque volutpat ac tincidunt vitae semper quis. In vitae turpis massa sed elementum tempus egestas. Diam ut venenatis tellus in metus vulputate eu scelerisque felis. Eget du");
            WriteLiteral(@"is at tellus at urna condimentum mattis pellentesque. Vestibulum lectus mauris ultrices eros in. Nunc scelerisque viverra mauris in. Lobortis elementum nibh tellus molestie nunc non blandit. Laoreet suspendisse interdum consectetur libero id faucibus nisl. Semper viverra nam libero justo laoreet sit amet cursus. Et magnis dis parturient montes nascetur ridiculus. Arcu risus quis varius quam quisque id diam.

            At tellus at urna condimentum mattis. Ut placerat orci nulla pellentesque dignissim enim sit. Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Adipiscing commodo elit at imperdiet dui accumsan. Commodo elit at imperdiet dui accumsan sit amet nulla. Ac tortor dignissim convallis aenean et tortor at risus viverra. Pulvinar proin gravida hendrerit lectus. Bibendum est ultricies integer quis auctor elit sed vulputate mi. Amet luctus venenatis lectus magna fringilla urna porttitor. Ut eu sem integer vitae justo eget magna. Risus in hendrerit gravida rutrum quisque non t");
            WriteLiteral(@"ellus. Ornare quam viverra orci sagittis. Lacus vel facilisis volutpat est velit. Cursus in hac habitasse platea dictumst quisque sagittis. Porta non pulvinar neque laoreet suspendisse interdum consectetur libero id. Leo vel orci porta non pulvinar neque. Tortor consequat id porta nibh.

            Blandit aliquam etiam erat velit scelerisque in dictum. Id diam maecenas ultricies mi eget mauris. Consequat nisl vel pretium lectus quam id. Ac tortor dignissim convallis aenean et. Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Dolor sit amet consectetur adipiscing elit duis. Nibh mauris cursus mattis molestie a iaculis at erat. A erat nam at lectus urna duis convallis. Eget nunc lobortis mattis aliquam faucibus purus in. Faucibus scelerisque eleifend donec pretium vulputate sapien nec sagittis. Dolor morbi non arcu risus quis varius. Mauris sit amet massa vitae tortor condimentum lacinia quis. Nunc consequat interdum varius sit amet mattis. Quis blandit turpis cursus in hac habitass");
            WriteLiteral(@"e platea dictumst quisque.

            Dolor sit amet consectetur adipiscing elit ut aliquam purus sit. Placerat vestibulum lectus mauris ultrices eros in. Arcu felis bibendum ut tristique et egestas quis. Fusce ut placerat orci nulla pellentesque dignissim enim. Egestas integer eget aliquet nibh praesent tristique magna sit. Adipiscing enim eu turpis egestas pretium aenean pharetra magna ac. Purus viverra accumsan in nisl nisi scelerisque eu ultrices. Mollis nunc sed id semper risus in hendrerit gravida rutrum. Enim tortor at auctor urna nunc id cursus. Ultricies tristique nulla aliquet enim tortor at auctor urna. Tincidunt id aliquet risus feugiat in ante metus dictum. Aliquet sagittis id consectetur purus ut. Vel orci porta non pulvinar. Et netus et malesuada fames ac turpis egestas. Nec feugiat in fermentum posuere urna nec tincidunt. Pretium aenean pharetra magna ac placerat vestibulum. Ac turpis egestas integer eget aliquet nibh.

            Nisl pretium fusce id velit ut. Enim ut tellus elementum");
            WriteLiteral(@" sagittis vitae et leo duis ut. At tempor commodo ullamcorper a lacus. Ultrices mi tempus imperdiet nulla malesuada pellentesque elit. Eget dolor morbi non arcu risus quis. Arcu vitae elementum curabitur vitae nunc sed velit. Leo integer malesuada nunc vel risus commodo viverra maecenas accumsan. Risus quis varius quam quisque id diam. Fames ac turpis egestas integer. Ut enim blandit volutpat maecenas. Vulputate eu scelerisque felis imperdiet proin fermentum leo. Ante in nibh mauris cursus mattis molestie. Lacus viverra vitae congue eu. Nam at lectus urna duis convallis convallis tellus id interdum. Duis ultricies lacus sed turpis. Elementum nisi quis eleifend quam adipiscing. Urna condimentum mattis pellentesque id nibh tortor id. Neque egestas congue quisque egestas. Nulla aliquet porttitor lacus luctus accumsan tortor posuere.

            Est pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat. Proin sed libero enim sed faucibus turpis in eu mi. Dolor sed viverra ipsum nunc aliquet b");
            WriteLiteral(@"ibendum enim facilisis. Dictumst vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt. Leo in vitae turpis massa sed elementum. Ornare quam viverra orci sagittis. Egestas integer eget aliquet nibh praesent tristique magna sit amet. Ac placerat vestibulum lectus mauris ultrices. Pellentesque habitant morbi tristique senectus et netus et malesuada fames. Maecenas accumsan lacus vel facilisis volutpat. Enim ut sem viverra aliquet eget.

            Sodales ut eu sem integer. Dignissim sodales ut eu sem integer vitae. Nunc aliquet bibendum enim facilisis gravida neque convallis a. Nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque. Ipsum a arcu cursus vitae congue mauris rhoncus. Pharetra vel turpis nunc eget lorem dolor sed viverra. Sapien pellentesque habitant morbi tristique senectus et netus et malesuada. Eu consequat ac felis donec et odio pellentesque diam. Hendrerit gravida rutrum quisque non tellus orci. Dignissim convallis aenean et tortor at risus viverra ");
            WriteLiteral(@"adipiscing at. Cursus euismod quis viverra nibh. Cras tincidunt lobortis feugiat vivamus.

            Nascetur ridiculus mus mauris vitae ultricies leo. Sit amet consectetur adipiscing elit duis tristique sollicitudin nibh. Ultricies mi eget mauris pharetra et ultrices neque ornare aenean. Ipsum nunc aliquet bibendum enim facilisis. Aliquet eget sit amet tellus cras adipiscing enim eu. Lectus proin nibh nisl condimentum id venenatis. Malesuada bibendum arcu vitae elementum curabitur. Maecenas pharetra convallis posuere morbi leo urna molestie at elementum. Diam vulputate ut pharetra sit amet. Enim lobortis scelerisque fermentum dui faucibus. Sit amet venenatis urna cursus eget nunc scelerisque viverra. Gravida cum sociis natoque penatibus et magnis dis. Diam sit amet nisl suscipit adipiscing bibendum est ultricies. Bibendum est ultricies integer quis. Lacus suspendisse faucibus interdum posuere lorem ipsum dolor sit amet. Nam at lectus urna duis. Adipiscing elit pellentesque habitant morbi tristique senect");
            WriteLiteral(@"us. Urna nunc id cursus metus aliquam eleifend mi in nulla.

            Cursus turpis massa tincidunt dui ut. Sed blandit libero volutpat sed cras ornare arcu dui vivamus. Nec feugiat in fermentum posuere urna nec tincidunt praesent. Diam maecenas sed enim ut sem viverra aliquet eget sit. Amet consectetur adipiscing elit ut aliquam purus sit. Enim nulla aliquet porttitor lacus luctus. Tellus elementum sagittis vitae et leo duis ut. At risus viverra adipiscing at in tellus integer feugiat. Nulla pellentesque dignissim enim sit. Purus semper eget duis at tellus. Facilisis volutpat est velit egestas dui id ornare arcu odio. Mattis pellentesque id nibh tortor id aliquet lectus proin. Ipsum nunc aliquet bibendum enim facilisis gravida neque convallis a.

            Volutpat lacus laoreet non curabitur. Dolor magna eget est lorem. Eu ultrices vitae auctor eu augue ut. Non quam lacus suspendisse faucibus interdum. Tortor pretium viverra suspendisse potenti nullam ac tortor. Neque volutpat ac tincidunt vitae se");
            WriteLiteral(@"mper quis lectus nulla at. Semper auctor neque vitae tempus quam pellentesque. Dignissim sodales ut eu sem. Praesent semper feugiat nibh sed. Mi in nulla posuere sollicitudin aliquam ultrices. Id eu nisl nunc mi ipsum faucibus vitae aliquet. Fermentum iaculis eu non diam.

            Sollicitudin nibh sit amet commodo. Blandit aliquam etiam erat velit scelerisque in dictum. In vitae turpis massa sed. Donec et odio pellentesque diam volutpat commodo sed egestas. Turpis egestas integer eget aliquet. Volutpat lacus laoreet non curabitur gravida arcu ac tortor dignissim. Vestibulum lectus mauris ultrices eros. Egestas dui id ornare arcu odio ut sem nulla pharetra. Mauris commodo quis imperdiet massa tincidunt. Sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus. Sit amet facilisis magna etiam tempor orci. Commodo viverra maecenas accumsan lacus vel. Justo donec enim diam vulputate ut. Velit aliquet sagittis id consectetur purus ut faucibus. Ultricies leo integer malesuada nunc vel.

 ");
            WriteLiteral(@"           Id leo in vitae turpis massa sed. Pharetra sit amet aliquam id diam maecenas. Arcu vitae elementum curabitur vitae. Sed vulputate odio ut enim blandit volutpat maecenas. Purus non enim praesent elementum facilisis leo vel. Vel quam elementum pulvinar etiam non quam lacus suspendisse. Blandit massa enim nec dui nunc mattis enim. In est ante in nibh mauris cursus mattis. Leo in vitae turpis massa sed elementum. Magnis dis parturient montes nascetur ridiculus mus mauris. Eget mi proin sed libero enim sed faucibus turpis. Sagittis nisl rhoncus mattis rhoncus urna. Nunc mi ipsum faucibus vitae aliquet nec ullamcorper sit. A condimentum vitae sapien pellentesque habitant morbi tristique senectus. Dui vivamus arcu felis bibendum. Massa massa ultricies mi quis hendrerit dolor magna. Nibh mauris cursus mattis molestie a iaculis at erat pellentesque. Ligula ullamcorper malesuada proin libero nunc.

            Amet cursus sit amet dictum sit amet justo donec enim. Accumsan tortor posuere ac ut consequat se");
            WriteLiteral(@"mper viverra nam libero. At tempor commodo ullamcorper a lacus vestibulum sed. Sit amet consectetur adipiscing elit ut aliquam purus. Sem integer vitae justo eget magna fermentum iaculis eu. Diam donec adipiscing tristique risus nec feugiat in fermentum. Eget est lorem ipsum dolor sit amet consectetur. Risus in hendrerit gravida rutrum quisque non tellus orci. Molestie nunc non blandit massa. Ut pharetra sit amet aliquam. Suspendisse ultrices gravida dictum fusce. Non tellus orci ac auctor augue mauris augue. Faucibus turpis in eu mi bibendum neque egestas congue quisque. In massa tempor nec feugiat nisl pretium fusce id. Sit amet volutpat consequat mauris nunc congue. Etiam erat velit scelerisque in. Libero volutpat sed cras ornare arcu dui vivamus arcu. Diam volutpat commodo sed egestas egestas fringilla. Velit egestas dui id ornare arcu odio ut sem. Mauris rhoncus aenean vel elit scelerisque mauris pellentesque pulvinar pellentesque.

            Maecenas pharetra convallis posuere morbi leo. Enim sit am");
            WriteLiteral(@"et venenatis urna cursus eget nunc scelerisque viverra. Enim praesent elementum facilisis leo vel fringilla est ullamcorper. Turpis in eu mi bibendum neque egestas. Tellus elementum sagittis vitae et. Vulputate dignissim suspendisse in est ante in nibh. Laoreet suspendisse interdum consectetur libero id faucibus. Non quam lacus suspendisse faucibus interdum posuere lorem ipsum dolor. Posuere sollicitudin aliquam ultrices sagittis orci a scelerisque purus. Scelerisque fermentum dui faucibus in ornare quam. Sit amet consectetur adipiscing elit duis tristique sollicitudin. Nunc non blandit massa enim nec. Eget nunc lobortis mattis aliquam. Id aliquet lectus proin nibh nisl condimentum. Faucibus pulvinar elementum integer enim. Massa tempor nec feugiat nisl pretium fusce id. Aliquet nibh praesent tristique magna.
        </p>
    </div>
</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(13310, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(13317, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dacf5842880cf0ea4902ea27d13649770a1cde119861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13358, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
