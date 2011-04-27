using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xaml;
using MonoTouch.UIKit;
using System.Text;
using System.IO;
using XamlForIphone;
using Sample;

namespace SilverlightApplication1
{
	public partial class MainPage : XamlForIphone.Canvas
	{
		public MainPage()
		{
			//var btn = XamlForIphone.UIButton();
			//btn.TouchDown += HandleBtnTouchDown;
		}
		
		public void HandleBtnTouchDown (object sender, EventArgs e)
		{
			var tb = (XamlForIphone.UITextView)this.FindName("CodeTb");
			
			//byte[] byteArray = Encoding.ASCII.GetBytes( tb.Text );
			//MemoryStream stream = new MemoryStream( byteArray ); 
			
			var obj = (UIElement)XamlServices.Parse(tb.Text);
			//var obj = (UIElement)XamlServices.Load(stream);
			obj.Frame = this.Bounds;
			var tb = (XamlForIphone.UITextField)obj.FindName("tbBinding");
			tb
			 var del = (AppDelegate)UIApplication.SharedApplication.Delegate;
			foreach(var view in del.secondaryVc.View.Subviews)
			{
				view.RemoveFromSuperview();
			}
			del.secondaryVc.View.AddSubview(obj);
			del.navigationController.PushViewController(del.secondaryVc,true);
		}
	}
}
