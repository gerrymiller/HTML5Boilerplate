using System.Web;
using System.Web.Optimization;

namespace HTML5Boilerplate
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/normalize.min.css",
                "~/Content/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/libs/modernizr-2.6.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/plugins.js",
                "~/Scripts/main.js"));
        }
    }
}