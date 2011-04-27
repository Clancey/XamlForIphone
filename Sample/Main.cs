
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreFoundation;
using System.Drawing;
using System.Xaml;
using System.Xml;
using System.IO;
using Microsoft.Phone.Controls;
using System.Threading;
using SilverlightApplication1;

namespace Sample
{
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : UIApplicationDelegate
	{
		// This method is invoked when the application has loaded its UI and its ready to run
		UILabel loadingLabel;
		public UINavigationController navigationController;
		public UIViewController mainvc;
		public UIViewController secondaryVc;
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// If you have defined a view, add it here:
			mainvc = new UIViewController();
			secondaryVc = new UIViewController();
			navigationController = new UINavigationController(mainvc);
			loadingLabel = new UILabel(window.Bounds);
			loadingLabel.Text = "Loading";
			loadingLabel.TextAlignment = UITextAlignment.Center;
			mainvc.View.AddSubview(loadingLabel);
			window.AddSubview (navigationController.View);
			window.MakeKeyAndVisible ();
			//navigationController.PushViewController(vc,false);
			start();
			//Thread thread = new Thread(start);
			//thread.Start();
			return true;
		}
		MainPage mainPage;
		public void start()
		{
			using(new NSAutoreleasePool()) {
				var frame = window.Frame;
				var directory = Path.Combine(NSBundle.MainBundle.ResourcePath,"MainPage.xaml");
				XamlXmlReader reader = new XamlXmlReader(directory);
				mainPage = (MainPage)XamlServices.Load(reader);
				mainPage.Frame = frame;
				this.InvokeOnMainThread( delegate {
					loadingLabel.RemoveFromSuperview();
					loadingLabel = null;
					mainvc.View.AddSubview(mainPage);
				});
				TextReader tr = new StreamReader(Path.Combine(NSBundle.MainBundle.ResourcePath,"load.xaml"));
				var tb = mainPage.FindName("CodeTb");
				((XamlForIphone.UITextView)tb).Text = tr.ReadToEnd() ;
			}
		}
		

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}
	}
}

