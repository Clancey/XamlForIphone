
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
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// If you have defined a view, add it here:
			// window.AddSubview (navigationController.View);
			loadingLabel = new UILabel(window.Bounds);
			loadingLabel.Text = "Loading";
			loadingLabel.TextAlignment = UITextAlignment.Center;
			window.AddSubview(loadingLabel);
			window.MakeKeyAndVisible ();
			Thread thread = new Thread(start);
			thread.Start();
			return true;
		}
		public void start()
		{
			var frame = window.Frame;
			frame.Y += 20;
			frame.Height -=20;
			var directory = Path.Combine(NSBundle.MainBundle.ResourcePath,"MainPage.xaml");
			XamlXmlReader reader = new XamlXmlReader(directory);
			UIView obj = (UIView)XamlServices.Load(reader);
			obj.Frame = frame;
			this.InvokeOnMainThread( delegate {
				loadingLabel.RemoveFromSuperview();
				loadingLabel = null;
				window.AddSubview(obj);
			});
		}
		

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}
	}
}

