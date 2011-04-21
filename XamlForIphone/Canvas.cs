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
		public static readonly DependencyProperty LeftProperty;
		
		static Canvas()
		{
			LeftProperty= DependencyProperty.Register ("Left", typeof(int), typeof(Canvas), new PropertyMetadata (OnLeftPropertyChanged));
		}

		/// <summary>
		/// ContentProperty property changed handler.
		/// </summary> 
		/// <param name="d">ContentControl that changed its Content.</param>
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnLeftPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			Console.WriteLine("left changed");
			Canvas source = d as Canvas;
			Debug.Assert (source != null, "The source is not an instance of ContentControl!");
			// Notify derived classes of the change 
			source.OnLeftChanged (e.OldValue, e.NewValue);
		}
		
		/// <summary>
		/// Called when the Content property changes. 
		/// </summary>
		/// <param name="oldContent">
		/// The old value of the Content property. 
		/// </param>
		/// <param name="newContent">
		/// The new value of the Content property. 
		/// </param> 
		protected virtual void OnLeftChanged (object oldContent, object newContent)
		{
			Console.WriteLine(newContent);
		}
		
		public static readonly DependencyProperty TopProperty = DependencyProperty.Register ("Top", typeof(int), typeof(Canvas), new PropertyMetadata (OnRightPropertyChanged));

		/// <summary>
		/// ContentProperty property changed handler.
		/// </summary> 
		/// <param name="d">ContentControl that changed its Content.</param>
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnRightPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			Console.WriteLine("top changed");
			Canvas source = d as Canvas;
			Debug.Assert (source != null, "The source is not an instance of ContentControl!");
			// Notify derived classes of the change 
			source.OnRightChanged (e.OldValue, e.NewValue);
		}
		#endregion Content
		
		/// <summary>
		/// Called when the Content property changes. 
		/// </summary>
		/// <param name="oldContent">
		/// The old value of the Content property. 
		/// </param>
		/// <param name="newContent">
		/// The new value of the Content property. 
		/// </param> 
		protected virtual void OnRightChanged (object oldContent, object newContent)
		{
			Console.WriteLine(newContent);
		}
		
		public static int GetLeft (IDependencyObject element){return (int)element.GetValue(Canvas.LeftProperty );	}
		public override void SubviewAdded (MonoTouch.UIKit.UIView uiview)
		{
			base.SubviewAdded (uiview);
			if(uiview is IDependencyObject)
			{
				
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
				Console.WriteLine("view added");
			}
		}
		
    }
}

