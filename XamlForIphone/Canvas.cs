using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Markup;
using System.Windows;
namespace XamlForIphone
{
	public partial class Canvas : UIView
	{
		#region Canvas
		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty LeftProperty = DependencyProperty.Register ("Left", typeof(int), typeof(Canvas), new PropertyMetadata (0, OnLeftPropertyChanged));


		public static int GetLeft (IDependencyObject element)
		{
			return (int)element.GetValue (Canvas.LeftProperty);
		}
		public static void SetLeft (IDependencyObject element, int value)
		{
			element.SetValue (Canvas.LeftProperty, value);
		}
		private static void OnLeftPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var frame = d.Frame;
			frame.X = float.Parse (e.NewValue.ToString ());
			d.Frame = frame;
		}
		public static readonly DependencyProperty TopProperty = DependencyProperty.Register ("Top", typeof(int), typeof(Canvas), new PropertyMetadata (OnTopPropertyChanged));

		public static int GetTop (IDependencyObject element)
		{
			return (int)element.GetValue (Canvas.TopProperty);
		}
		public static void SetTop (IDependencyObject element, int value)
		{
			element.SetValue (Canvas.TopProperty, value);
		}
		private static void OnTopPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var frame = d.Frame;
			frame.Y = float.Parse (e.NewValue.ToString ());
			d.Frame = frame;
		}
		#endregion Content
		public override void SubviewAdded (MonoTouch.UIKit.UIView uiview)
		{
			base.SubviewAdded (uiview);
			if (uiview is IDependencyObject) {
				
				var theview = uiview as IDependencyObject;
				//var test = GetLeft(theview);
				//Console.WriteLine(test);
								/*
				var left =  theview.GetValue(LeftProperty);
				var right =  theview.GetValue(RightProperty);
				var frame = theview.Frame;
				frame.X = (int)left;
				frame.Y = (int)right;
				theview.Frame = frame;
				*/
Console.WriteLine ("view added");
			}
		}
		
	}
}

