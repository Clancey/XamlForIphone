// Copyright © Microsoft Corporation. 
// This source is subject to the Microsoft Source License for Silverlight Controls (March 2008 Release).
// Please see http://go.microsoft.com/fwlink/?LinkID=111693 for details.
// All other rights reserved. 

using System;
using System.ComponentModel; 
using System.Diagnostics; 
using System.Windows.Markup; 
using XamlForIphone;

namespace System.Windows.Controls
{
    /// <summary>
    /// Represents a control with a single piece of content. 
    /// </summary> 
    /// <remarks>
    /// A ContentControl has a limited default style.  If you want to enhance 
    /// the appearance of the control, you can create a new control template
    /// that uses &lt;ContentPresenter Content="{TemplateBinding Content}" /&gt;
    /// to display the value of the Content property. 
    /// </remarks>
    [ContentProperty("Content")]
    public partial class ContentControl : UIView
    { 
		#region Canvas
		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty LeftProperty = DependencyProperty.Register ("Left", typeof(int), typeof(Canvas), new PropertyMetadata (OnLeftPropertyChanged));

		/// <summary>
		/// ContentProperty property changed handler.
		/// </summary> 
		/// <param name="d">ContentControl that changed its Content.</param>
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnLeftPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
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
		
		public static readonly DependencyProperty RightProperty = DependencyProperty.Register ("Right", typeof(int), typeof(Canvas), new PropertyMetadata (OnLeftPropertyChanged));

		/// <summary>
		/// ContentProperty property changed handler.
		/// </summary> 
		/// <param name="d">ContentControl that changed its Content.</param>
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnRightPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
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
		
    }
} 
