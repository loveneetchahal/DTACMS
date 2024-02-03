#pragma checksum "D:\Projects\CMS\DTACMS\Views\Dash\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305975a800e610c08e58fa7bfa528c2c3f2649b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dash_Index), @"mvc.1.0.view", @"/Views/Dash/Index.cshtml")]
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
#line 1 "D:\Projects\CMS\DTACMS\Views\_ViewImports.cshtml"
using dtacms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\CMS\DTACMS\Views\_ViewImports.cshtml"
using dtacms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305975a800e610c08e58fa7bfa528c2c3f2649b4", @"/Views/Dash/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c612dd7a5a0ed9af7916d4dce063962ddda597", @"/Views/_ViewImports.cshtml")]
    public class Views_Dash_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\CMS\DTACMS\Views\Dash\Index.cshtml"
  
ViewData["Title"] = "Dashboard Page";
Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Row -->
<div class=""row"">

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-4 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Total Views</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">40,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-4 col-md-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-");
            WriteLiteral(@"center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Total Posts</div>
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col-auto"">
                                <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">23</div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Pending Requests Card Example -->
    <div class=""col-xl-4 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=");
            WriteLiteral(@"""text-xs font-weight-bold text-warning text-uppercase mb-1"">Total Contacts</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-comments fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Content Row -->

<div class=""row"">

    <!-- Area Chart -->
    <div class=""col-xl-8 col-lg-7"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Posts Views</h6>
                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown""
                        aria-haspopup=""true"" aria-expanded=""false"">
             ");
            WriteLiteral(@"           <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                        aria-labelledby=""dropdownMenuLink"">
                        <div class=""dropdown-header"">Dropdown Header:</div>
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                </div>
            </div>
        </div>
    </div>

    <!-- Pie Chart -->
    <div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">
            ");
            WriteLiteral(@"<!-- Card Header - Dropdown -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Contact Analysis</h6>
                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown""
                        aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                        aria-labelledby=""dropdownMenuLink"">
                        <div class=""dropdown-header"">Dropdown Header:</div>
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a clas");
            WriteLiteral(@"s=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </div>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-pie pt-4 pb-2"">
                    <canvas id=""myPieChart""></canvas>
                </div>
                <div class=""mt-4 text-center small"">
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-primary""></i> Direct
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-success""></i> Social
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-info""></i> Referral
                    </span>
                </div>
            </div>
        </div>
    </div>
</div>



</div>");
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