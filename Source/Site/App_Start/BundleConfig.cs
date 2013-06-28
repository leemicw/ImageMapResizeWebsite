using System.Web;
using System.Web.Optimization;

namespace ImageMapResizeWebsite
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.Add(new StyleBundle("~/cssBundles/Shared/RootLayoutPage").Include("~/css/Shared/RootLayoutPage.css"));

			bundles.Add(new ScriptBundle("~/jsBundles/root").Include("~/js/modernizr-2.6.2.js"));
		}

	}
}