using System;

using System.Drawing;
using XamlForIphone;
using System.Windows;
namespace XamlForIphone
{
	internal partial class ViewHelper : MonoTouch.UIKit.UIView, IViewHelper
	{
		public UIElement Host{get;set;}
		public ViewHelper (UIElement parent)
		{
			Host = parent;
		}
		
		public override void LayoutSubviews ()
		{
			Host.Arrange(new Rect( this.Frame));
		}
	}
}

