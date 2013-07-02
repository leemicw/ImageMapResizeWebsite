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

			bundles.Add(new StyleBundle("~/cssBundles/Contribute/Index").Include("~/css/Contribute/Index.css"));

			bundles.Add(new StyleBundle("~/cssBundles/Usage/Index").Include("~/css/Usage/Index.css"));

			
			//this needs to be seperate so it can be included after all the css files are loaded
			bundles.Add(new ScriptBundle("~/jsBundles/respond").Include("~/Scripts/respond.js"));
		}

	}
}