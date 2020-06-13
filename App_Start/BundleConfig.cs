using System.Web;
using System.Web.Optimization;

namespace VentaPlantasEcommerce
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                       "~/Scripts/jquery.min.js",
                       "~/Scripts/jquery-migrate-3.0.1.min.js",
                       "~/Scripts/popper.min.js",
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/jquery.easing.1.3.js",
                       "~/Scripts/jquery.waypoints.min.js",
                       "~/Scripts/jquery.stellar.min.js",
                       "~/Scripts/owl.carousel.min.js",
                       "~/Scripts/jquery.magnific-popup.min.js",
                       "~/Scripts/aos.js",
                       "~/Scripts/jquery.animateNumber.min.js",
                       "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/scrollax.min.js",
                        "~/Scripts/main.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/open-iconic-bootstrap.min.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/owl.theme.default.min.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/aos.css",
                      "~/Content/css/ionicons.min.css",
                      "~/Content/css/bootstrap-datepicker.css",
                      "~/Content/css/jquery.timepicker.css",
                      "~/Content/css/flaticon.css",
                      "~/Content/css/icomoon.css",
                      "~/Content/css/style.css"
                      ));
        }
    }
}
