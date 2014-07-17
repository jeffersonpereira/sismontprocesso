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
                        "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.js", "~/Scripts/jquery.mask.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryplugin").Include(
                        "~/Scripts/jquery.metisMenu.js"));


            bundles.Add(new ScriptBundle("~/bundles/tema").Include(
                        "~/Scripts/tema/treemenu.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").
                Include("~/Scripts/angular.js").
                Include("~/Scripts/angular-animate.min.js").
                Include("~/Scripts/angular-cookie.min.js").
                Include("~/Scripts/angular-loader.min.js").
                Include("~/Scripts/angular-mocks.js").
                Include("~/Scripts/angular-resource.min.js").
                Include("~/Scripts/angular-route.min.js").
                Include("~/Scripts/angular-sanitize.min.js").
                Include("~/Scripts/angular-scenario.js").
                Include("~/Scripts/angular-touch.min.js"));
                        

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/locales/bootstrap-datepicker.pt-BR.js",
                      "~/Scripts/ui-bootstrap-tpls-0.11.0.min.js",
                      "~/Scripts/respond.js", "~/Scripts/bootstrap-session-timeout.min.js"));

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
                      "~/Content/font-awesome.css"));
        }
    }
}
