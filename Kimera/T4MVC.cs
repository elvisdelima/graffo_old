﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static Kimera.Controllers.ConfigurationController Configuration = new Kimera.Controllers.T4MVC_ConfigurationController();
    public static Kimera.Controllers.HomeController Home = new Kimera.Controllers.T4MVC_HomeController();
    public static Kimera.Controllers.TestController Test = new Kimera.Controllers.T4MVC_TestController();
    public static Kimera.Controllers.TrelloController Trello = new Kimera.Controllers.T4MVC_TrelloController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Highcharts_3_0_1 {
            private const string URLPATH = "~/Scripts/Highcharts-3.0.1";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class js {
                private const string URLPATH = "~/Scripts/Highcharts-3.0.1/js";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class adapters {
                    private const string URLPATH = "~/Scripts/Highcharts-3.0.1/js/adapters";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string mootools_adapter_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mootools-adapter.min.js") ? Url("mootools-adapter.min.js") : Url("mootools-adapter.js");
                    public static readonly string mootools_adapter_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/mootools-adapter.src.min.js") ? Url("mootools-adapter.src.min.js") : Url("mootools-adapter.src.js");
                    public static readonly string prototype_adapter_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/prototype-adapter.min.js") ? Url("prototype-adapter.min.js") : Url("prototype-adapter.js");
                    public static readonly string prototype_adapter_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/prototype-adapter.src.min.js") ? Url("prototype-adapter.src.min.js") : Url("prototype-adapter.src.js");
                }
            
                public static readonly string highcharts_more_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts-more.min.js") ? Url("highcharts-more.min.js") : Url("highcharts-more.js");
                public static readonly string highcharts_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts.min.js") ? Url("highcharts.min.js") : Url("highcharts.js");
                public static readonly string highcharts_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts.src.min.js") ? Url("highcharts.src.min.js") : Url("highcharts.src.js");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class modules {
                    private const string URLPATH = "~/Scripts/Highcharts-3.0.1/js/modules";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string canvas_tools_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/canvas-tools.min.js") ? Url("canvas-tools.min.js") : Url("canvas-tools.js");
                    public static readonly string canvas_tools_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/canvas-tools.src.min.js") ? Url("canvas-tools.src.min.js") : Url("canvas-tools.src.js");
                    public static readonly string data_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/data.min.js") ? Url("data.min.js") : Url("data.js");
                    public static readonly string data_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/data.src.min.js") ? Url("data.src.min.js") : Url("data.src.js");
                    public static readonly string exporting_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/exporting.min.js") ? Url("exporting.min.js") : Url("exporting.js");
                    public static readonly string exporting_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/exporting.src.min.js") ? Url("exporting.src.min.js") : Url("exporting.src.js");
                    public static readonly string funnel_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/funnel.min.js") ? Url("funnel.min.js") : Url("funnel.js");
                    public static readonly string funnel_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/funnel.src.min.js") ? Url("funnel.src.min.js") : Url("funnel.src.js");
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class themes {
                    private const string URLPATH = "~/Scripts/Highcharts-3.0.1/js/themes";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string dark_blue_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/dark-blue.min.js") ? Url("dark-blue.min.js") : Url("dark-blue.js");
                    public static readonly string dark_green_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/dark-green.min.js") ? Url("dark-green.min.js") : Url("dark-green.js");
                    public static readonly string gray_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/gray.min.js") ? Url("gray.min.js") : Url("gray.js");
                    public static readonly string grid_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/grid.min.js") ? Url("grid.min.js") : Url("grid.js");
                    public static readonly string skies_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/skies.min.js") ? Url("skies.min.js") : Url("skies.js");
                }
            
            }
        
        }
    
        public static readonly string highcharts_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts-all.min.js") ? Url("highcharts-all.min.js") : Url("highcharts-all.js");
        public static readonly string highcharts_more_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts-more.min.js") ? Url("highcharts-more.min.js") : Url("highcharts-more.js");
        public static readonly string highcharts_more_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts-more.src.min.js") ? Url("highcharts-more.src.min.js") : Url("highcharts-more.src.js");
        public static readonly string highcharts_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts.min.js") ? Url("highcharts.min.js") : Url("highcharts.js");
        public static readonly string highcharts_src_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/highcharts.src.min.js") ? Url("highcharts.src.min.js") : Url("highcharts.src.js");
        public static readonly string jquery_2_0_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.0.0.intellisense.min.js") ? Url("jquery-2.0.0.intellisense.min.js") : Url("jquery-2.0.0.intellisense.js");
        public static readonly string jquery_2_0_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.0.0.min.js") ? Url("jquery-2.0.0.min.js") : Url("jquery-2.0.0.js");
        public static readonly string jquery_2_0_0_min_js = Url("jquery-2.0.0.min.js");
        public static readonly string jquery_2_0_0_min_map = Url("jquery-2.0.0.min.map");
        public static readonly string jquery_2_1_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.0.intellisense.min.js") ? Url("jquery-2.1.0.intellisense.min.js") : Url("jquery-2.1.0.intellisense.js");
        public static readonly string jquery_2_1_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.0.min.js") ? Url("jquery-2.1.0.min.js") : Url("jquery-2.1.0.js");
        public static readonly string jquery_2_1_0_min_js = Url("jquery-2.1.0.min.js");
        public static readonly string jquery_2_1_0_min_map = Url("jquery-2.1.0.min.map");
        public static readonly string jquery_ui_1_10_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.3.min.js") ? Url("jquery-ui-1.10.3.min.js") : Url("jquery-ui-1.10.3.js");
        public static readonly string jquery_ui_1_10_3_min_js = Url("jquery-ui-1.10.3.min.js");
        public static readonly string TwitterBootstrapMvcJs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/TwitterBootstrapMvcJs.min.js") ? Url("TwitterBootstrapMvcJs.min.js") : Url("TwitterBootstrapMvcJs.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
             
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string chart_png = Url("chart.png");
        public static readonly string cover_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/cover.min.css") ? Url("cover.min.css") : Url("cover.css");
             
        public static readonly string Eagle_jpg = Url("Eagle.jpg");
        public static readonly string graffo_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/graffo.min.css") ? Url("graffo.min.css") : Url("graffo.css");
             
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591

