using System.Web;
using System.Web.Optimization;

namespace BiffFestival
{
   public class BundleConfig
   {
      // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
      public static void RegisterBundles(BundleCollection bundles)
      {
#if DEBUG
         BundleTable.EnableOptimizations = false;
#else
         BundleTable.EnableOptimizations = true;
#endif


         bundles.Add(new ScriptBundle("~/bundles/mainjquery").Include(
                     "~/Scripts/jquery-{version}.js"));

         bundles.Add(new ScriptBundle("~/bundles/mainjqueryval").Include(
                     "~/Scripts/jquery.validate*"));

         // Use the development version of Modernizr to develop with and learn from. Then, when you're
         // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
         bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                     "~/Scripts/modernizr-*"));

         bundles.Add(new ScriptBundle("~/bundles/mainbootstrap").Include(
                   "~/Scripts/bootstrap.js",
                   "~/Scripts/flipclock.min.js",
                   "~/Scripts/flipclock-custom.js",
                   "~/Scripts/parallax.min.js",
                   "~/Scripts/carousel-custom.js"
                   ));

         bundles.Add(new ScriptBundle("~/bundles/mainplugins").Include(
            "~/Content/Plugins/jquery.parallax-1.1.3.js",
            "~/Content/Plugins/carousel-partners.js"
         ));

         bundles.Add(new StyleBundle("~/bundles/maincss").Include(
                   "~/Content/bootstrap.css",
                   "~/Content/Css/index.css",
                   "~/Content/Css/docs.css",
                    "~/Content/Css/flipclock.css",
                    "~/Content/Css/carousel-partners.css"

            ));
      }
   }
}
