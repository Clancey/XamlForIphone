//
// Contact:
//   Moonlight List (moonlight-list@lists.ximian.com)
//
// Copyright 2007 Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Windows;
using Mono;
using System.Windows.Markup;
using XamlForIphone;

namespace XamlForIphone {
	public partial class Canvas : Panel {
		public static readonly DependencyProperty LeftProperty = DependencyProperty.Register ("Left", typeof(int), typeof(Canvas), new PropertyMetadata (0, OnLeftPropertyChanged));

		private static void OnLeftPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var frame = d.Frame;
			frame.X = float.Parse (e.NewValue.ToString ());
			d.Frame = frame;
		}
		public static readonly DependencyProperty TopProperty = DependencyProperty.Register ("Top", typeof(int), typeof(Canvas), new PropertyMetadata (OnTopPropertyChanged));

		private static void OnTopPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var frame = d.Frame;
			frame.Y = float.Parse (e.NewValue.ToString ());
			d.Frame = frame;
		}

		public static readonly DependencyProperty ZIndexProperty = DependencyProperty.Register ("ZIndex", typeof(int), typeof(Canvas), new PropertyMetadata ());// DependencyProperty.Lookup (Kind.CANVAS, "ZIndex", typeof (int));
		//internal static readonly DependencyProperty ZProperty = DependencyProperty.Register ("Z", typeof(int), typeof(Canvas), new PropertyMetadata ());// DependencyProperty.Lookup (Kind.CANVAS, "Z", typeof (double));

		public static double GetLeft (UIElement element)
		{
			return (double) element.GetValue (Canvas.LeftProperty);
		}
		
		public static void SetLeft (UIElement element, double length)
		{
			element.SetValue (Canvas.LeftProperty, length);
		}
		
		public static double GetTop (UIElement element)
		{
			return (double) element.GetValue (Canvas.TopProperty);
		}
		
		public static void SetTop (UIElement element, double length)
		{
			element.SetValue (Canvas.TopProperty, length);
		}
		
		public static int GetZIndex (UIElement element)
		{
			return (int) element.GetValue (Canvas.ZIndexProperty);
		}
		
		public static void SetZIndex (UIElement element, int value)
		{
			element.SetValue (Canvas.ZIndexProperty, value);
		}
		
		protected sealed override Size ArrangeOverride (Size arrangeSize)
		{
			return base.ArrangeOverride (arrangeSize);
		}

		protected sealed override Size MeasureOverride (Size constraint)
		{
			return base.MeasureOverride (constraint);
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
				//child->ClearValue (LayoutInformation::LayoutClipProperty);
				child = walker.Step();
			}

			//return finalSize;
		}
	}
}
