using System.Web;
using System.Web.Optimization;

namespace ImageMapResizeWebsite
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.Add(new StyleBundle("~/cssBundles/Shared/RootLayoutPage").Include("~/css/Shared/RootLayoutPage.css"));

			bundles.Add(new ScriptBundle("~/jsBundles/root").Include(
				"~/Scripts/modernizr-2.6.2.js",
				"~/Scripts/jquery-1.10.1.js",
				"~/js/jquery.ImageMapResize.js"
				));

			bundles.Add(new StyleBundle("~/cssBundles/Home/Index").Include("~/css/Home/Index.css"));
		}

	}
}