using System.Web;
using System.Web.Optimization;

namespace BuscaGoogle
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                                    "~/Scripts/jquery.unobtrusive*",
                                    "~/Scripts/jquery.validate*",
                                    "~/Scripts/methods_pt.js"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/smartresize.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/bootstrap-datepicker.pt-BR.js",
                      "~/Scripts/bootstrap-table.js",
                      "~/Scripts/bootstrap-table-pt-BR.js",
                      "~/Scripts/bootstrap-dialog.js"));

            bundles.Add(new ScriptBundle("~/bundles/modalform").Include(
                        "~/Scripts/modalform.js"));

      //      var bundle1 = new ScriptBundle("~/bundles/bootstrap") { Orderer = new PassthruBundleOrderer() };


         //   bundles.Add(bundle1);

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                  "~/Content/bootstrap.css",
                                  "~/Content/font-awesome.css",
                                  "~/Content/bootstrap-datepicker.css",
                                  "~/Content/bootstrap-table.css",
                                  "~/Content/bootstrap-dialog.css",
                                  "~/Content/iconesCustom.css",
                                  "~/Content/custom.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
