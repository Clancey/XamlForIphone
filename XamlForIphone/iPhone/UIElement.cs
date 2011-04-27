using System;
using System.Windows;
using System.Drawing;
using System.ComponentModel;
namespace XamlForIphone
{
	public partial class UIElement : DependencyObject
	{
		public UIElement ()
		{
			CreateHandle();
			setupEvents();
		}
		
		internal MonoTouch.UIKit.UIView m_helper;
		internal MonoTouch.UIKit.UIView m_view{get;set;}
		
		public static implicit operator MonoTouch.UIKit.UIView (UIElement element)
		{
			return element.m_view;
		}
		
		protected virtual void CreateHandle ()
		{
			m_helper = new ViewHelper (this);
			m_view = m_helper;
		}
		internal virtual void setupEvents()
		{
			
		}
		
		public string Name {get;set;}
		public virtual new RectangleF Frame {
			get {return m_view.Frame;}
			set {m_view.Frame = value;}
		}
		
		public virtual void AddSubview(MonoTouch.UIKit.UIView view)
		{
			m_view.AddSubview(view);
		}
		
		public System.Windows.Size RenderSize {
			get {
				return new System.Windows.Size (Frame.Width,Frame.Height);
			}
		}
		public int Width
		{
			get {return int.Parse(Frame.Width.ToString());}
			set {desiredSize.Width = value;}
		}
		
		public int Height
		{
			get {return int.Parse(Frame.Height.ToString());}
			set {desiredSize.Height = value;}
		}
		
		internal void AddToView(UIElement parent)
		{
			MonoTouch.UIKit.UIView parentView = parent.m_view;
			if(m_view.Superview != parentView)
			{
				m_view.RemoveFromSuperview();
				parentView.AddSubview(m_view);
			}
		}
		
		
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		//public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
		public System.Drawing.PointF Center {get{return m_helper.Center;}set{m_helper.Center = value;}}
		public MonoTouch.CoreGraphics.CGAffineTransform Transform {get{return m_helper.Transform;}set{m_helper.Transform = value;}}
		public System.Boolean MultipleTouchEnabled {get{return m_helper.MultipleTouchEnabled;}set{m_helper.MultipleTouchEnabled = value;}}
		public System.Boolean ExclusiveTouch {get{return m_helper.ExclusiveTouch;}set{m_helper.ExclusiveTouch = value;}}
		public System.Boolean AutosizesSubviews {get{return m_helper.AutosizesSubviews;}set{m_helper.AutosizesSubviews = value;}}
		public MonoTouch.UIKit.UIViewAutoresizing AutoresizingMask {get{return m_helper.AutoresizingMask;}set{m_helper.AutoresizingMask = value;}}
		public MonoTouch.UIKit.UIView Superview {get{return m_helper.Superview;}}
		public MonoTouch.UIKit.UIView[] Subviews {get{return m_helper.Subviews;}}
		public MonoTouch.UIKit.UIWindow Window {get{return m_helper.Window;}}
		public System.Boolean ClipsToBounds {get{return m_helper.ClipsToBounds;}set{m_helper.ClipsToBounds = value;}}
		public System.Single Alpha {get{return m_helper.Alpha;}set{m_helper.Alpha = value;}}
		public System.Boolean Opaque {get{return m_helper.Opaque;}set{m_helper.Opaque = value;}}
		public System.Boolean ClearsContextBeforeDrawing {get{return m_helper.ClearsContextBeforeDrawing;}set{m_helper.ClearsContextBeforeDrawing = value;}}
		public System.Boolean Hidden {get{return m_helper.Hidden;}set{m_helper.Hidden = value;}}
		public MonoTouch.UIKit.UIViewContentMode ContentMode {get{return m_helper.ContentMode;}set{m_helper.ContentMode = value;}}
		public System.Drawing.RectangleF ContentStretch {get{return m_helper.ContentStretch;}set{m_helper.ContentStretch = value;}}
		public MonoTouch.UIKit.UIGestureRecognizer[] GestureRecognizers {get{return m_helper.GestureRecognizers;}}
		public System.Single ContentScaleFactor {get{return m_helper.ContentScaleFactor;}set{m_helper.ContentScaleFactor = value;}}
		public MonoTouch.UIKit.UIViewPrintFormatter ViewPrintFormatter {get{return m_helper.ViewPrintFormatter;}}
		public System.Boolean EnableInputClicksWhenVisible {get{return m_helper.EnableInputClicksWhenVisible;}}
		public MonoTouch.UIKit.UIResponder NextResponder {get{return m_helper.NextResponder;}}
		public System.Boolean CanBecomeFirstResponder {get{return m_helper.CanBecomeFirstResponder;}}
		public System.Boolean CanResignFirstResponder {get{return m_helper.CanResignFirstResponder;}}
		public System.Boolean IsFirstResponder {get{return m_helper.IsFirstResponder;}}
		public MonoTouch.Foundation.NSUndoManager UndoManager {get{return m_helper.UndoManager;}}
		public MonoTouch.UIKit.UIView InputAccessoryView {get{return m_helper.InputAccessoryView;}}
		public MonoTouch.UIKit.UIView InputView {get{return m_helper.InputView;}}
		public System.IntPtr SuperHandle {get{return m_helper.SuperHandle;}}
		public System.IntPtr Handle {get{return m_helper.Handle;}set{m_helper.Handle = value;}}
		#endregion
		
	}
}

