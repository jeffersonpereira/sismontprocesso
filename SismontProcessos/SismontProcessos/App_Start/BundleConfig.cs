using System.Web;
using System.Web.Optimization;

namespace SismontProcessos
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery-{version}.js",
                        "~/Scripts/jquery/jquery.js",
                        "~/Scripts/jquery/jquery.mask.min.js",
                        "~/Scripts/jquery/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryplugin").Include(
                        "~/Scripts/jquery/jquery.metisMenu.js",
                        "~/Scripts/jquery/jquery.idletimeout.js",
                        "~/Scripts/jquery/jquery.idletimer.js"));


            bundles.Add(new ScriptBundle("~/bundles/tema").Include(
                        "~/Scripts/tema/treemenu.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").
                Include("~/Scripts/angularjs/angular.js").
                Include("~/Scripts/angularjs/angular-animate.min.js").
                Include("~/Scripts/angularjs/angular-cookie.min.js").
                Include("~/Scripts/angularjs/angular-loader.min.js").
                Include("~/Scripts/angularjs/angular-mocks.js").
                Include("~/Scripts/angularjs/angular-resource.min.js").
                Include("~/Scripts/angularjs/angular-route.min.js").
                Include("~/Scripts/angularjs/angular-sanitize.min.js").
                Include("~/Scripts/angularjs/angular-scenario.js").
                Include("~/Scripts/angularjs/angular-touch.min.js").
                Include("~/Scripts/angularjs/angular-file-upload.min.js").
                Include("~/Scripts/toaster.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.js",
                      "~/Scripts/bootstrap/bootstrap-datepicker.js",
                      "~/Scripts/locales/bootstrap-datepicker.pt-BR.js",
                      "~/Scripts/bootstrap/ui-bootstrap-tpls-0.11.0.min.js",
                      "~/Scripts/bootstrap/bootstrap.file-input.js",
                      "~/Scripts/bootstrap/jasny-bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include(
                         "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                         "~/Scripts/angular-ui/ui-bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/bootstrap-datepicker3.css",
                      "~/Content/site.css",
                      "~/Content/ng-grid.min.css",
                      "~/Content/style-xs.css",
                      "~/Content/style-sm.css",
                      "~/Content/style-md.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery-ui.min.css",
                      "~/Content/jasny-bootstrap.min.css",
                      "~/Content/toaster.css"));
        }
    }
}
