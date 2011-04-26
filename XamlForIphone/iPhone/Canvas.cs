using System;
using System.Collections.Specialized;
using System.Windows;
namespace XamlForIphone
{
	public partial class Canvas : Panel
	{
		public Canvas ()
		{
			
		}
		
		internal override void ArrangeInternal (Rect finalRect)
		{
			VisualTreeWalker walker = new VisualTreeWalker (this);
			var child = walker.Step();
			while (child != null) {
				Size desired = child.DesiredSize;
				Rect child_final = new Rect (GetLeft (child), GetTop (child),
							 desired.Width, desired.Height);
				child.Arrange (child_final);
				MonoTouch.UIKit.UIView view = child;
				child.AddToView(this);				
				//child->ClearValue (LayoutInformation::LayoutClipProperty);
				child = walker.Step();
			}

			//return finalSize;
		}
	}
}

