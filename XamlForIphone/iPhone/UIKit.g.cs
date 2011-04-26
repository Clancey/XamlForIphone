using System;
using System.ComponentModel;
using System.Windows;
namespace XamlForIphone
{
	public  partial class UIView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIView (UIView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIActionSheet : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIActionSheet (UIActionSheet element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIActionSheet m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIActionSheet();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UIActionSheetDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.String Title {get{return m_helper.Title;}set{m_helper.Title = value;}}
		public MonoTouch.UIKit.UIActionSheetStyle Style {get{return m_helper.Style;}set{m_helper.Style = value;}}
		public System.Int32 ButtonCount {get{return m_helper.ButtonCount;}}
		public System.Int32 CancelButtonIndex {get{return m_helper.CancelButtonIndex;}set{m_helper.CancelButtonIndex = value;}}
		public System.Int32 DestructiveButtonIndex {get{return m_helper.DestructiveButtonIndex;}set{m_helper.DestructiveButtonIndex = value;}}
		public System.Int32 FirstOtherButtonIndex {get{return m_helper.FirstOtherButtonIndex;}}
		public System.Boolean Visible {get{return m_helper.Visible;}set{m_helper.Visible = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIAlertView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIAlertView (UIAlertView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIAlertView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIAlertView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIAlertViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public System.String Title {get{return m_helper.Title;}set{m_helper.Title = value;}}
		public System.String Message {get{return m_helper.Message;}set{m_helper.Message = value;}}
		public System.Int32 ButtonCount {get{return m_helper.ButtonCount;}}
		public System.Int32 CancelButtonIndex {get{return m_helper.CancelButtonIndex;}set{m_helper.CancelButtonIndex = value;}}
		public System.Int32 FirstOtherButtonIndex {get{return m_helper.FirstOtherButtonIndex;}}
		public System.Boolean Visible {get{return m_helper.Visible;}set{m_helper.Visible = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIControl : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIControl (UIControl element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIControl m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIControl();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIPickerView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIPickerView (UIPickerView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIPickerView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIPickerView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public MonoTouch.UIKit.UIPickerViewModel Source {get{return m_helper.Source;}set{m_helper.Source = value;}}
		public MonoTouch.UIKit.UIPickerViewModel Model {get{return m_helper.Model;}set{m_helper.Model = value;}}
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject DataSource {get{return m_helper.DataSource;}set{m_helper.DataSource = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UIPickerViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.Boolean ShowSelectionIndicator {get{return m_helper.ShowSelectionIndicator;}set{m_helper.ShowSelectionIndicator = value;}}
		public System.Int32 NumberOfComponents {get{return m_helper.NumberOfComponents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UISegmentedControl : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UISegmentedControl (UISegmentedControl element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UISegmentedControl m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UISegmentedControl();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UISegmentedControlStyle ControlStyle {get{return m_helper.ControlStyle;}set{m_helper.ControlStyle = value;}}
		public System.Boolean Momentary {get{return m_helper.Momentary;}set{m_helper.Momentary = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TintColor {get{return m_helper.TintColor;}set{m_helper.TintColor = value;}}
		public System.Int32 NumberOfSegments {get{return m_helper.NumberOfSegments;}}
		public System.Int32 SelectedSegment {get{return m_helper.SelectedSegment;}set{m_helper.SelectedSegment = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UITableView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UITableView (UITableView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UITableView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UITableView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public MonoTouch.UIKit.UITableViewSource Source {get{return m_helper.Source;}set{m_helper.Source = value;}}
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UITableViewStyle Style {get{return m_helper.Style;}}
		public MonoTouch.Foundation.NSObject WeakDataSource {get{return m_helper.WeakDataSource;}set{m_helper.WeakDataSource = value;}}
		public MonoTouch.UIKit.UITableViewDataSource DataSource {get{return m_helper.DataSource;}set{m_helper.DataSource = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UITableViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.Single RowHeight {get{return m_helper.RowHeight;}set{m_helper.RowHeight = value;}}
		public System.Single SectionHeaderHeight {get{return m_helper.SectionHeaderHeight;}set{m_helper.SectionHeaderHeight = value;}}
		public System.Single SectionFooterHeight {get{return m_helper.SectionFooterHeight;}set{m_helper.SectionFooterHeight = value;}}
		public MonoTouch.UIKit.UITableViewCell[] VisibleCells {get{return m_helper.VisibleCells;}}
		public MonoTouch.Foundation.NSIndexPath[] IndexPathsForVisibleRows {get{return m_helper.IndexPathsForVisibleRows;}}
		public System.Boolean Editing {get{return m_helper.Editing;}set{m_helper.Editing = value;}}
		public System.Boolean AllowsSelection {get{return m_helper.AllowsSelection;}set{m_helper.AllowsSelection = value;}}
		public System.Boolean AllowsSelectionDuringEditing {get{return m_helper.AllowsSelectionDuringEditing;}set{m_helper.AllowsSelectionDuringEditing = value;}}
		public MonoTouch.Foundation.NSIndexPath IndexPathForSelectedRow {get{return m_helper.IndexPathForSelectedRow;}}
		public System.Int32 SectionIndexMinimumDisplayRowCount {get{return m_helper.SectionIndexMinimumDisplayRowCount;}set{m_helper.SectionIndexMinimumDisplayRowCount = value;}}
		public MonoTouch.UIKit.UITableViewCellSeparatorStyle SeparatorStyle {get{return m_helper.SeparatorStyle;}set{m_helper.SeparatorStyle = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor SeparatorColor {get{return m_helper.SeparatorColor;}set{m_helper.SeparatorColor = value;}}
		public MonoTouch.UIKit.UIView TableHeaderView {get{return m_helper.TableHeaderView;}set{m_helper.TableHeaderView = value;}}
		public MonoTouch.UIKit.UIView TableFooterView {get{return m_helper.TableFooterView;}set{m_helper.TableFooterView = value;}}
		public MonoTouch.UIKit.UIView BackgroundView {get{return m_helper.BackgroundView;}set{m_helper.BackgroundView = value;}}
		public System.Drawing.PointF ContentOffset {get{return m_helper.ContentOffset;}set{m_helper.ContentOffset = value;}}
		public System.Drawing.SizeF ContentSize {get{return m_helper.ContentSize;}set{m_helper.ContentSize = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ContentInset {get{return m_helper.ContentInset;}set{m_helper.ContentInset = value;}}
		//public MonoTouch.UIKit.UIScrollViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.Boolean Bounces {get{return m_helper.Bounces;}set{m_helper.Bounces = value;}}
		public System.Boolean AlwaysBounceVertical {get{return m_helper.AlwaysBounceVertical;}set{m_helper.AlwaysBounceVertical = value;}}
		public System.Boolean AlwaysBounceHorizontal {get{return m_helper.AlwaysBounceHorizontal;}set{m_helper.AlwaysBounceHorizontal = value;}}
		public System.Boolean ShowsHorizontalScrollIndicator {get{return m_helper.ShowsHorizontalScrollIndicator;}set{m_helper.ShowsHorizontalScrollIndicator = value;}}
		public System.Boolean ShowsVerticalScrollIndicator {get{return m_helper.ShowsVerticalScrollIndicator;}set{m_helper.ShowsVerticalScrollIndicator = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ScrollIndicatorInsets {get{return m_helper.ScrollIndicatorInsets;}set{m_helper.ScrollIndicatorInsets = value;}}
		public MonoTouch.UIKit.UIScrollViewIndicatorStyle IndicatorStyle {get{return m_helper.IndicatorStyle;}set{m_helper.IndicatorStyle = value;}}
		public System.Single DecelerationRate {get{return m_helper.DecelerationRate;}set{m_helper.DecelerationRate = value;}}
		public System.Boolean PagingEnabled {get{return m_helper.PagingEnabled;}set{m_helper.PagingEnabled = value;}}
		public System.Boolean DirectionalLockEnabled {get{return m_helper.DirectionalLockEnabled;}set{m_helper.DirectionalLockEnabled = value;}}
		public System.Boolean ScrollEnabled {get{return m_helper.ScrollEnabled;}set{m_helper.ScrollEnabled = value;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}set{m_helper.Tracking = value;}}
		public System.Boolean Dragging {get{return m_helper.Dragging;}set{m_helper.Dragging = value;}}
		public System.Boolean Decelerating {get{return m_helper.Decelerating;}set{m_helper.Decelerating = value;}}
		public System.Boolean DelaysContentTouches {get{return m_helper.DelaysContentTouches;}set{m_helper.DelaysContentTouches = value;}}
		public System.Boolean CanCancelContentTouches {get{return m_helper.CanCancelContentTouches;}set{m_helper.CanCancelContentTouches = value;}}
		public System.Single MinimumZoomScale {get{return m_helper.MinimumZoomScale;}set{m_helper.MinimumZoomScale = value;}}
		public System.Single MaximumZoomScale {get{return m_helper.MaximumZoomScale;}set{m_helper.MaximumZoomScale = value;}}
		public System.Single ZoomScale {get{return m_helper.ZoomScale;}set{m_helper.ZoomScale = value;}}
		public System.Boolean BouncesZoom {get{return m_helper.BouncesZoom;}set{m_helper.BouncesZoom = value;}}
		public System.Boolean Zooming {get{return m_helper.Zooming;}set{m_helper.Zooming = value;}}
		public System.Boolean ZoomBouncing {get{return m_helper.ZoomBouncing;}set{m_helper.ZoomBouncing = value;}}
		public System.Boolean ScrollsToTop {get{return m_helper.ScrollsToTop;}set{m_helper.ScrollsToTop = value;}}
		public MonoTouch.UIKit.UIScrollViewGetZoomView ViewForZoomingInScrollView {get{return m_helper.ViewForZoomingInScrollView;}set{m_helper.ViewForZoomingInScrollView = value;}}
		public MonoTouch.UIKit.UIScrollViewCondition ShouldScrollToTop {get{return m_helper.ShouldScrollToTop;}set{m_helper.ShouldScrollToTop = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UITableViewCell : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UITableViewCell (UITableViewCell element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UITableViewCell m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UITableViewCell();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIImageView ImageView {get{return m_helper.ImageView;}}
		public MonoTouch.UIKit.UILabel TextLabel {get{return m_helper.TextLabel;}}
		public MonoTouch.UIKit.UILabel DetailTextLabel {get{return m_helper.DetailTextLabel;}}
		public MonoTouch.UIKit.UIView ContentView {get{return m_helper.ContentView;}}
		public MonoTouch.UIKit.UIView BackgroundView {get{return m_helper.BackgroundView;}set{m_helper.BackgroundView = value;}}
		public MonoTouch.UIKit.UIView SelectedBackgroundView {get{return m_helper.SelectedBackgroundView;}set{m_helper.SelectedBackgroundView = value;}}
		public System.String ReuseIdentifier {get{return m_helper.ReuseIdentifier;}}
		public MonoTouch.UIKit.UITableViewCellSelectionStyle SelectionStyle {get{return m_helper.SelectionStyle;}set{m_helper.SelectionStyle = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UITableViewCellEditingStyle EditingStyle {get{return m_helper.EditingStyle;}}
		public System.Boolean ShowsReorderControl {get{return m_helper.ShowsReorderControl;}set{m_helper.ShowsReorderControl = value;}}
		public System.Boolean ShouldIndentWhileEditing {get{return m_helper.ShouldIndentWhileEditing;}set{m_helper.ShouldIndentWhileEditing = value;}}
		public MonoTouch.UIKit.UITableViewCellAccessory Accessory {get{return m_helper.Accessory;}set{m_helper.Accessory = value;}}
		public MonoTouch.UIKit.UIView AccessoryView {get{return m_helper.AccessoryView;}set{m_helper.AccessoryView = value;}}
		public MonoTouch.UIKit.UITableViewCellAccessory EditingAccessory {get{return m_helper.EditingAccessory;}set{m_helper.EditingAccessory = value;}}
		public MonoTouch.UIKit.UIView EditingAccessoryView {get{return m_helper.EditingAccessoryView;}set{m_helper.EditingAccessoryView = value;}}
		public System.Int32 IndentationLevel {get{return m_helper.IndentationLevel;}set{m_helper.IndentationLevel = value;}}
		public System.Single IndentationWidth {get{return m_helper.IndentationWidth;}set{m_helper.IndentationWidth = value;}}
		public System.Boolean Editing {get{return m_helper.Editing;}set{m_helper.Editing = value;}}
		public System.Boolean ShowingDeleteConfirmation {get{return m_helper.ShowingDeleteConfirmation;}set{m_helper.ShowingDeleteConfirmation = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UITextField : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UITextField (UITextField element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UITextField m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UITextField();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.String Text {get{return m_helper.Text;}set{m_helper.Text = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TextColor {get{return m_helper.TextColor;}set{m_helper.TextColor = value;}}
		public MonoTouch.UIKit.UIFont Font {get{return m_helper.Font;}set{m_helper.Font = value;}}
		public MonoTouch.UIKit.UITextAlignment TextAlignment {get{return m_helper.TextAlignment;}set{m_helper.TextAlignment = value;}}
		public MonoTouch.UIKit.UITextBorderStyle BorderStyle {get{return m_helper.BorderStyle;}set{m_helper.BorderStyle = value;}}
		public System.String Placeholder {get{return m_helper.Placeholder;}set{m_helper.Placeholder = value;}}
		public System.Boolean ClearsOnBeginEditing {get{return m_helper.ClearsOnBeginEditing;}set{m_helper.ClearsOnBeginEditing = value;}}
		public System.Boolean AdjustsFontSizeToFitWidth {get{return m_helper.AdjustsFontSizeToFitWidth;}set{m_helper.AdjustsFontSizeToFitWidth = value;}}
		public System.Single MinimumFontSize {get{return m_helper.MinimumFontSize;}set{m_helper.MinimumFontSize = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UITextFieldDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public MonoTouch.UIKit.UIImage Background {get{return m_helper.Background;}set{m_helper.Background = value;}}
		public MonoTouch.UIKit.UIImage DisabledBackground {get{return m_helper.DisabledBackground;}set{m_helper.DisabledBackground = value;}}
		public System.Boolean IsEditing {get{return m_helper.IsEditing;}}
		public MonoTouch.UIKit.UITextFieldViewMode ClearButtonMode {get{return m_helper.ClearButtonMode;}set{m_helper.ClearButtonMode = value;}}
		public MonoTouch.UIKit.UIView LeftView {get{return m_helper.LeftView;}set{m_helper.LeftView = value;}}
		public MonoTouch.UIKit.UIView RightView {get{return m_helper.RightView;}set{m_helper.RightView = value;}}
		public MonoTouch.UIKit.UITextFieldViewMode LeftViewMode {get{return m_helper.LeftViewMode;}set{m_helper.LeftViewMode = value;}}
		public MonoTouch.UIKit.UITextFieldViewMode RightViewMode {get{return m_helper.RightViewMode;}set{m_helper.RightViewMode = value;}}
		public MonoTouch.UIKit.UITextAutocapitalizationType AutocapitalizationType {get{return m_helper.AutocapitalizationType;}set{m_helper.AutocapitalizationType = value;}}
		public MonoTouch.UIKit.UITextAutocorrectionType AutocorrectionType {get{return m_helper.AutocorrectionType;}set{m_helper.AutocorrectionType = value;}}
		public MonoTouch.UIKit.UIKeyboardType KeyboardType {get{return m_helper.KeyboardType;}set{m_helper.KeyboardType = value;}}
		public MonoTouch.UIKit.UIKeyboardAppearance KeyboardAppearance {get{return m_helper.KeyboardAppearance;}set{m_helper.KeyboardAppearance = value;}}
		public MonoTouch.UIKit.UIReturnKeyType ReturnKeyType {get{return m_helper.ReturnKeyType;}set{m_helper.ReturnKeyType = value;}}
		public System.Boolean EnablesReturnKeyAutomatically {get{return m_helper.EnablesReturnKeyAutomatically;}set{m_helper.EnablesReturnKeyAutomatically = value;}}
		public System.Boolean SecureTextEntry {get{return m_helper.SecureTextEntry;}set{m_helper.SecureTextEntry = value;}}
		public MonoTouch.UIKit.UIView InputAccessoryView {get{return m_helper.InputAccessoryView;}set{m_helper.InputAccessoryView = value;}}
		public MonoTouch.UIKit.UIView InputView {get{return m_helper.InputView;}set{m_helper.InputView = value;}}
		public MonoTouch.UIKit.UITextFieldCondition ShouldBeginEditing {get{return m_helper.ShouldBeginEditing;}set{m_helper.ShouldBeginEditing = value;}}
		public MonoTouch.UIKit.UITextFieldCondition ShouldEndEditing {get{return m_helper.ShouldEndEditing;}set{m_helper.ShouldEndEditing = value;}}
		public MonoTouch.UIKit.UITextFieldCondition ShouldClear {get{return m_helper.ShouldClear;}set{m_helper.ShouldClear = value;}}
		public MonoTouch.UIKit.UITextFieldCondition ShouldReturn {get{return m_helper.ShouldReturn;}set{m_helper.ShouldReturn = value;}}
		public MonoTouch.UIKit.UITextFieldChange ShouldChangeCharacters {get{return m_helper.ShouldChangeCharacters;}set{m_helper.ShouldChangeCharacters = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		public System.IntPtr SuperHandle {get{return m_helper.SuperHandle;}}
		public System.IntPtr Handle {get{return m_helper.Handle;}set{m_helper.Handle = value;}}
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class UITextView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UITextView (UITextView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UITextView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UITextView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.String Text {get{return m_helper.Text;}set{m_helper.Text = value;}}
		public MonoTouch.UIKit.UIFont Font {get{return m_helper.Font;}set{m_helper.Font = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TextColor {get{return m_helper.TextColor;}set{m_helper.TextColor = value;}}
		public System.Boolean Editable {get{return m_helper.Editable;}set{m_helper.Editable = value;}}
		public MonoTouch.UIKit.UITextAlignment TextAlignment {get{return m_helper.TextAlignment;}set{m_helper.TextAlignment = value;}}
		public MonoTouch.Foundation.NSRange SelectedRange {get{return m_helper.SelectedRange;}set{m_helper.SelectedRange = value;}}
		public System.Boolean HasText {get{return m_helper.HasText;}}
		public MonoTouch.UIKit.UITextViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UIDataDetectorType DataDetectorTypes {get{return m_helper.DataDetectorTypes;}set{m_helper.DataDetectorTypes = value;}}
		public MonoTouch.UIKit.UITextAutocapitalizationType AutocapitalizationType {get{return m_helper.AutocapitalizationType;}set{m_helper.AutocapitalizationType = value;}}
		public MonoTouch.UIKit.UITextAutocorrectionType AutocorrectionType {get{return m_helper.AutocorrectionType;}set{m_helper.AutocorrectionType = value;}}
		public MonoTouch.UIKit.UIKeyboardType KeyboardType {get{return m_helper.KeyboardType;}set{m_helper.KeyboardType = value;}}
		public MonoTouch.UIKit.UIKeyboardAppearance KeyboardAppearance {get{return m_helper.KeyboardAppearance;}set{m_helper.KeyboardAppearance = value;}}
		public MonoTouch.UIKit.UIReturnKeyType ReturnKeyType {get{return m_helper.ReturnKeyType;}set{m_helper.ReturnKeyType = value;}}
		public System.Boolean EnablesReturnKeyAutomatically {get{return m_helper.EnablesReturnKeyAutomatically;}set{m_helper.EnablesReturnKeyAutomatically = value;}}
		public System.Boolean SecureTextEntry {get{return m_helper.SecureTextEntry;}set{m_helper.SecureTextEntry = value;}}
		public MonoTouch.UIKit.UIView InputAccessoryView {get{return m_helper.InputAccessoryView;}set{m_helper.InputAccessoryView = value;}}
		public MonoTouch.UIKit.UIView InputView {get{return m_helper.InputView;}set{m_helper.InputView = value;}}
		public MonoTouch.UIKit.UITextViewCondition ShouldBeginEditing {get{return m_helper.ShouldBeginEditing;}set{m_helper.ShouldBeginEditing = value;}}
		public MonoTouch.UIKit.UITextViewCondition ShouldEndEditing {get{return m_helper.ShouldEndEditing;}set{m_helper.ShouldEndEditing = value;}}
		public MonoTouch.UIKit.UITextViewChange ShouldChangeText {get{return m_helper.ShouldChangeText;}set{m_helper.ShouldChangeText = value;}}
		public MonoTouch.UIKit.UIScrollViewGetZoomView ViewForZoomingInScrollView {get{return m_helper.ViewForZoomingInScrollView;}set{m_helper.ViewForZoomingInScrollView = value;}}
		public MonoTouch.UIKit.UIScrollViewCondition ShouldScrollToTop {get{return m_helper.ShouldScrollToTop;}set{m_helper.ShouldScrollToTop = value;}}
		public System.Drawing.PointF ContentOffset {get{return m_helper.ContentOffset;}set{m_helper.ContentOffset = value;}}
		public System.Drawing.SizeF ContentSize {get{return m_helper.ContentSize;}set{m_helper.ContentSize = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ContentInset {get{return m_helper.ContentInset;}set{m_helper.ContentInset = value;}}
		//public MonoTouch.UIKit.UIScrollViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.Boolean Bounces {get{return m_helper.Bounces;}set{m_helper.Bounces = value;}}
		public System.Boolean AlwaysBounceVertical {get{return m_helper.AlwaysBounceVertical;}set{m_helper.AlwaysBounceVertical = value;}}
		public System.Boolean AlwaysBounceHorizontal {get{return m_helper.AlwaysBounceHorizontal;}set{m_helper.AlwaysBounceHorizontal = value;}}
		public System.Boolean ShowsHorizontalScrollIndicator {get{return m_helper.ShowsHorizontalScrollIndicator;}set{m_helper.ShowsHorizontalScrollIndicator = value;}}
		public System.Boolean ShowsVerticalScrollIndicator {get{return m_helper.ShowsVerticalScrollIndicator;}set{m_helper.ShowsVerticalScrollIndicator = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ScrollIndicatorInsets {get{return m_helper.ScrollIndicatorInsets;}set{m_helper.ScrollIndicatorInsets = value;}}
		public MonoTouch.UIKit.UIScrollViewIndicatorStyle IndicatorStyle {get{return m_helper.IndicatorStyle;}set{m_helper.IndicatorStyle = value;}}
		public System.Single DecelerationRate {get{return m_helper.DecelerationRate;}set{m_helper.DecelerationRate = value;}}
		public System.Boolean PagingEnabled {get{return m_helper.PagingEnabled;}set{m_helper.PagingEnabled = value;}}
		public System.Boolean DirectionalLockEnabled {get{return m_helper.DirectionalLockEnabled;}set{m_helper.DirectionalLockEnabled = value;}}
		public System.Boolean ScrollEnabled {get{return m_helper.ScrollEnabled;}set{m_helper.ScrollEnabled = value;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}set{m_helper.Tracking = value;}}
		public System.Boolean Dragging {get{return m_helper.Dragging;}set{m_helper.Dragging = value;}}
		public System.Boolean Decelerating {get{return m_helper.Decelerating;}set{m_helper.Decelerating = value;}}
		public System.Boolean DelaysContentTouches {get{return m_helper.DelaysContentTouches;}set{m_helper.DelaysContentTouches = value;}}
		public System.Boolean CanCancelContentTouches {get{return m_helper.CanCancelContentTouches;}set{m_helper.CanCancelContentTouches = value;}}
		public System.Single MinimumZoomScale {get{return m_helper.MinimumZoomScale;}set{m_helper.MinimumZoomScale = value;}}
		public System.Single MaximumZoomScale {get{return m_helper.MaximumZoomScale;}set{m_helper.MaximumZoomScale = value;}}
		public System.Single ZoomScale {get{return m_helper.ZoomScale;}set{m_helper.ZoomScale = value;}}
		public System.Boolean BouncesZoom {get{return m_helper.BouncesZoom;}set{m_helper.BouncesZoom = value;}}
		public System.Boolean Zooming {get{return m_helper.Zooming;}set{m_helper.Zooming = value;}}
		public System.Boolean ZoomBouncing {get{return m_helper.ZoomBouncing;}set{m_helper.ZoomBouncing = value;}}
		public System.Boolean ScrollsToTop {get{return m_helper.ScrollsToTop;}set{m_helper.ScrollsToTop = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		public System.IntPtr SuperHandle {get{return m_helper.SuperHandle;}}
		public System.IntPtr Handle {get{return m_helper.Handle;}set{m_helper.Handle = value;}}
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class UIWindow : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIWindow (UIWindow element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIWindow m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIWindow();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Boolean IsKeyWindow {get{return m_helper.IsKeyWindow;}}
		public System.Single WindowLevel {get{return m_helper.WindowLevel;}set{m_helper.WindowLevel = value;}}
		public MonoTouch.UIKit.UIViewController RootViewController {get{return m_helper.RootViewController;}set{m_helper.RootViewController = value;}}
		public MonoTouch.UIKit.UIScreen Screen {get{return m_helper.Screen;}set{m_helper.Screen = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIActivityIndicatorView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIActivityIndicatorView (UIActivityIndicatorView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIActivityIndicatorView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIActivityIndicatorView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIActivityIndicatorViewStyle ActivityIndicatorViewStyle {get{return m_helper.ActivityIndicatorViewStyle;}set{m_helper.ActivityIndicatorViewStyle = value;}}
		public System.Boolean HidesWhenStopped {get{return m_helper.HidesWhenStopped;}set{m_helper.HidesWhenStopped = value;}}
		public System.Boolean IsAnimating {get{return m_helper.IsAnimating;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIBezierPath : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIBezierPath (UIBezierPath element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIBezierPath m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIBezierPath();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.CoreGraphics.CGPath CGPath {get{return m_helper.CGPath;}}
		public System.Boolean Empty {get{return m_helper.Empty;}set{m_helper.Empty = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}}
		public System.Drawing.PointF CurrentPoint {get{return m_helper.CurrentPoint;}}
		public System.Single LineWidth {get{return m_helper.LineWidth;}set{m_helper.LineWidth = value;}}
		public MonoTouch.CoreGraphics.CGLineCap LineCapStyle {get{return m_helper.LineCapStyle;}set{m_helper.LineCapStyle = value;}}
		public MonoTouch.CoreGraphics.CGLineJoin LineJoinStyle {get{return m_helper.LineJoinStyle;}set{m_helper.LineJoinStyle = value;}}
		public System.Single MiterLimit {get{return m_helper.MiterLimit;}set{m_helper.MiterLimit = value;}}
		public System.Single Flatness {get{return m_helper.Flatness;}set{m_helper.Flatness = value;}}
		public System.Boolean UsesEvenOddFillRule {get{return m_helper.UsesEvenOddFillRule;}set{m_helper.UsesEvenOddFillRule = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIButton : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIButton (UIButton element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIButton m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIButton();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIEdgeInsets ContentEdgeInsets {get{return m_helper.ContentEdgeInsets;}set{m_helper.ContentEdgeInsets = value;}}
		public MonoTouch.UIKit.UIEdgeInsets TitleEdgeInsets {get{return m_helper.TitleEdgeInsets;}set{m_helper.TitleEdgeInsets = value;}}
		public System.Boolean ReverseTitleShadowWhenHighlighted {get{return m_helper.ReverseTitleShadowWhenHighlighted;}set{m_helper.ReverseTitleShadowWhenHighlighted = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ImageEdgeInsets {get{return m_helper.ImageEdgeInsets;}set{m_helper.ImageEdgeInsets = value;}}
		public System.Boolean AdjustsImageWhenHighlighted {get{return m_helper.AdjustsImageWhenHighlighted;}set{m_helper.AdjustsImageWhenHighlighted = value;}}
		public System.Boolean AdjustsImageWhenDisabled {get{return m_helper.AdjustsImageWhenDisabled;}set{m_helper.AdjustsImageWhenDisabled = value;}}
		public System.Boolean ShowsTouchWhenHighlighted {get{return m_helper.ShowsTouchWhenHighlighted;}set{m_helper.ShowsTouchWhenHighlighted = value;}}
		public MonoTouch.UIKit.UIButtonType ButtonType {get{return m_helper.ButtonType;}}
		public System.String CurrentTitle {get{return m_helper.CurrentTitle;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor CurrentTitleColor {get{return m_helper.CurrentTitleColor;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor CurrentTitleShadowColor {get{return m_helper.CurrentTitleShadowColor;}}
		public MonoTouch.UIKit.UIImage CurrentImage {get{return m_helper.CurrentImage;}}
		public MonoTouch.UIKit.UIImage CurrentBackgroundImage {get{return m_helper.CurrentBackgroundImage;}}
		public MonoTouch.UIKit.UILabel TitleLabel {get{return m_helper.TitleLabel;}}
		public MonoTouch.UIKit.UIImageView ImageView {get{return m_helper.ImageView;}}
		public MonoTouch.UIKit.UIFont Font {get{return m_helper.Font;}set{m_helper.Font = value;}}
		public MonoTouch.UIKit.UILineBreakMode LineBreakMode {get{return m_helper.LineBreakMode;}set{m_helper.LineBreakMode = value;}}
		public System.Drawing.SizeF TitleShadowOffset {get{return m_helper.TitleShadowOffset;}set{m_helper.TitleShadowOffset = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UILabel : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UILabel (UILabel element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UILabel m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UILabel();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.String Text {get{return m_helper.Text;}set{m_helper.Text = value;}}
		public MonoTouch.UIKit.UIFont Font {get{return m_helper.Font;}set{m_helper.Font = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TextColor {get{return m_helper.TextColor;}set{m_helper.TextColor = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor ShadowColor {get{return m_helper.ShadowColor;}set{m_helper.ShadowColor = value;}}
		public System.Drawing.SizeF ShadowOffset {get{return m_helper.ShadowOffset;}set{m_helper.ShadowOffset = value;}}
		public MonoTouch.UIKit.UITextAlignment TextAlignment {get{return m_helper.TextAlignment;}set{m_helper.TextAlignment = value;}}
		public MonoTouch.UIKit.UILineBreakMode LineBreakMode {get{return m_helper.LineBreakMode;}set{m_helper.LineBreakMode = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor HighlightedTextColor {get{return m_helper.HighlightedTextColor;}set{m_helper.HighlightedTextColor = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Int32 Lines {get{return m_helper.Lines;}set{m_helper.Lines = value;}}
		public System.Boolean AdjustsFontSizeToFitWidth {get{return m_helper.AdjustsFontSizeToFitWidth;}set{m_helper.AdjustsFontSizeToFitWidth = value;}}
		public System.Single MinimumFontSize {get{return m_helper.MinimumFontSize;}set{m_helper.MinimumFontSize = value;}}
		public MonoTouch.UIKit.UIBaselineAdjustment BaselineAdjustment {get{return m_helper.BaselineAdjustment;}set{m_helper.BaselineAdjustment = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIImageView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIImageView (UIImageView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIImageView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIImageView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIImage Image {get{return m_helper.Image;}set{m_helper.Image = value;}}
		public MonoTouch.UIKit.UIImage HighlightedImage {get{return m_helper.HighlightedImage;}set{m_helper.HighlightedImage = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIImage[] AnimationImages {get{return m_helper.AnimationImages;}set{m_helper.AnimationImages = value;}}
		public MonoTouch.UIKit.UIImage[] HighlightedAnimationImages {get{return m_helper.HighlightedAnimationImages;}set{m_helper.HighlightedAnimationImages = value;}}
		public System.Double AnimationDuration {get{return m_helper.AnimationDuration;}set{m_helper.AnimationDuration = value;}}
		public System.Int32 AnimationRepeatCount {get{return m_helper.AnimationRepeatCount;}set{m_helper.AnimationRepeatCount = value;}}
		public System.Boolean IsAnimating {get{return m_helper.IsAnimating;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIDatePicker : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIDatePicker (UIDatePicker element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIDatePicker m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIDatePicker();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIDatePickerMode Mode {get{return m_helper.Mode;}set{m_helper.Mode = value;}}
		public MonoTouch.Foundation.NSLocale Locale {get{return m_helper.Locale;}set{m_helper.Locale = value;}}
		public MonoTouch.Foundation.NSTimeZone TimeZone {get{return m_helper.TimeZone;}set{m_helper.TimeZone = value;}}
		public MonoTouch.Foundation.NSCalendar Calendar {get{return m_helper.Calendar;}set{m_helper.Calendar = value;}}
		public MonoTouch.Foundation.NSDate Date {get{return m_helper.Date;}set{m_helper.Date = value;}}
		public MonoTouch.Foundation.NSDate MinimumDate {get{return m_helper.MinimumDate;}set{m_helper.MinimumDate = value;}}
		public MonoTouch.Foundation.NSDate MaximumDate {get{return m_helper.MaximumDate;}set{m_helper.MaximumDate = value;}}
		public System.Double CountDownDuration {get{return m_helper.CountDownDuration;}set{m_helper.CountDownDuration = value;}}
		public System.Int32 MinuteInterval {get{return m_helper.MinuteInterval;}set{m_helper.MinuteInterval = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UINavigationBar : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UINavigationBar (UINavigationBar element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UINavigationBar m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UINavigationBar();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIBarStyle BarStyle {get{return m_helper.BarStyle;}set{m_helper.BarStyle = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UINavigationBarDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TintColor {get{return m_helper.TintColor;}set{m_helper.TintColor = value;}}
		public System.Boolean Translucent {get{return m_helper.Translucent;}set{m_helper.Translucent = value;}}
		public MonoTouch.UIKit.UINavigationItem TopItem {get{return m_helper.TopItem;}}
		public MonoTouch.UIKit.UINavigationItem BackItem {get{return m_helper.BackItem;}}
		public MonoTouch.UIKit.UINavigationItem[] Items {get{return m_helper.Items;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIPageControl : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIPageControl (UIPageControl element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIPageControl m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIPageControl();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Int32 Pages {get{return m_helper.Pages;}set{m_helper.Pages = value;}}
		public System.Int32 CurrentPage {get{return m_helper.CurrentPage;}set{m_helper.CurrentPage = value;}}
		public System.Boolean HidesForSinglePage {get{return m_helper.HidesForSinglePage;}set{m_helper.HidesForSinglePage = value;}}
		public System.Boolean DefersCurrentPageDisplay {get{return m_helper.DefersCurrentPageDisplay;}set{m_helper.DefersCurrentPageDisplay = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIProgressView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIProgressView (UIProgressView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIProgressView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIProgressView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIProgressViewStyle Style {get{return m_helper.Style;}set{m_helper.Style = value;}}
		public System.Single Progress {get{return m_helper.Progress;}set{m_helper.Progress = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIScrollView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIScrollView (UIScrollView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIScrollView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIScrollView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Drawing.PointF ContentOffset {get{return m_helper.ContentOffset;}set{m_helper.ContentOffset = value;}}
		public System.Drawing.SizeF ContentSize {get{return m_helper.ContentSize;}set{m_helper.ContentSize = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ContentInset {get{return m_helper.ContentInset;}set{m_helper.ContentInset = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UIScrollViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.Boolean Bounces {get{return m_helper.Bounces;}set{m_helper.Bounces = value;}}
		public System.Boolean AlwaysBounceVertical {get{return m_helper.AlwaysBounceVertical;}set{m_helper.AlwaysBounceVertical = value;}}
		public System.Boolean AlwaysBounceHorizontal {get{return m_helper.AlwaysBounceHorizontal;}set{m_helper.AlwaysBounceHorizontal = value;}}
		public System.Boolean ShowsHorizontalScrollIndicator {get{return m_helper.ShowsHorizontalScrollIndicator;}set{m_helper.ShowsHorizontalScrollIndicator = value;}}
		public System.Boolean ShowsVerticalScrollIndicator {get{return m_helper.ShowsVerticalScrollIndicator;}set{m_helper.ShowsVerticalScrollIndicator = value;}}
		public MonoTouch.UIKit.UIEdgeInsets ScrollIndicatorInsets {get{return m_helper.ScrollIndicatorInsets;}set{m_helper.ScrollIndicatorInsets = value;}}
		public MonoTouch.UIKit.UIScrollViewIndicatorStyle IndicatorStyle {get{return m_helper.IndicatorStyle;}set{m_helper.IndicatorStyle = value;}}
		public System.Single DecelerationRate {get{return m_helper.DecelerationRate;}set{m_helper.DecelerationRate = value;}}
		public System.Boolean PagingEnabled {get{return m_helper.PagingEnabled;}set{m_helper.PagingEnabled = value;}}
		public System.Boolean DirectionalLockEnabled {get{return m_helper.DirectionalLockEnabled;}set{m_helper.DirectionalLockEnabled = value;}}
		public System.Boolean ScrollEnabled {get{return m_helper.ScrollEnabled;}set{m_helper.ScrollEnabled = value;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}set{m_helper.Tracking = value;}}
		public System.Boolean Dragging {get{return m_helper.Dragging;}set{m_helper.Dragging = value;}}
		public System.Boolean Decelerating {get{return m_helper.Decelerating;}set{m_helper.Decelerating = value;}}
		public System.Boolean DelaysContentTouches {get{return m_helper.DelaysContentTouches;}set{m_helper.DelaysContentTouches = value;}}
		public System.Boolean CanCancelContentTouches {get{return m_helper.CanCancelContentTouches;}set{m_helper.CanCancelContentTouches = value;}}
		public System.Single MinimumZoomScale {get{return m_helper.MinimumZoomScale;}set{m_helper.MinimumZoomScale = value;}}
		public System.Single MaximumZoomScale {get{return m_helper.MaximumZoomScale;}set{m_helper.MaximumZoomScale = value;}}
		public System.Single ZoomScale {get{return m_helper.ZoomScale;}set{m_helper.ZoomScale = value;}}
		public System.Boolean BouncesZoom {get{return m_helper.BouncesZoom;}set{m_helper.BouncesZoom = value;}}
		public System.Boolean Zooming {get{return m_helper.Zooming;}set{m_helper.Zooming = value;}}
		public System.Boolean ZoomBouncing {get{return m_helper.ZoomBouncing;}set{m_helper.ZoomBouncing = value;}}
		public System.Boolean ScrollsToTop {get{return m_helper.ScrollsToTop;}set{m_helper.ScrollsToTop = value;}}
		public MonoTouch.UIKit.UIScrollViewGetZoomView ViewForZoomingInScrollView {get{return m_helper.ViewForZoomingInScrollView;}set{m_helper.ViewForZoomingInScrollView = value;}}
		public MonoTouch.UIKit.UIScrollViewCondition ShouldScrollToTop {get{return m_helper.ShouldScrollToTop;}set{m_helper.ShouldScrollToTop = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UISearchBar : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UISearchBar (UISearchBar element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UISearchBar m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UISearchBar();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIBarStyle BarStyle {get{return m_helper.BarStyle;}set{m_helper.BarStyle = value;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UISearchBarDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.String Text {get{return m_helper.Text;}set{m_helper.Text = value;}}
		public System.String Prompt {get{return m_helper.Prompt;}set{m_helper.Prompt = value;}}
		public System.String Placeholder {get{return m_helper.Placeholder;}set{m_helper.Placeholder = value;}}
		public System.Boolean ShowsBookmarkButton {get{return m_helper.ShowsBookmarkButton;}set{m_helper.ShowsBookmarkButton = value;}}
		public System.Boolean ShowsCancelButton {get{return m_helper.ShowsCancelButton;}set{m_helper.ShowsCancelButton = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TintColor {get{return m_helper.TintColor;}set{m_helper.TintColor = value;}}
		public System.Int32 SelectedScopeButtonIndex {get{return m_helper.SelectedScopeButtonIndex;}set{m_helper.SelectedScopeButtonIndex = value;}}
		public System.Boolean ShowsScopeBar {get{return m_helper.ShowsScopeBar;}set{m_helper.ShowsScopeBar = value;}}
		public MonoTouch.UIKit.UITextAutocapitalizationType AutocapitalizationType {get{return m_helper.AutocapitalizationType;}set{m_helper.AutocapitalizationType = value;}}
		public MonoTouch.UIKit.UITextAutocorrectionType AutocorrectionType {get{return m_helper.AutocorrectionType;}set{m_helper.AutocorrectionType = value;}}
		public MonoTouch.UIKit.UIKeyboardType KeyboardType {get{return m_helper.KeyboardType;}set{m_helper.KeyboardType = value;}}
		public System.String[] ScopeButtonTitles {get{return m_helper.ScopeButtonTitles;}set{m_helper.ScopeButtonTitles = value;}}
		public System.Boolean Translucent {get{return m_helper.Translucent;}set{m_helper.Translucent = value;}}
		public System.Boolean SearchResultsButtonSelected {get{return m_helper.SearchResultsButtonSelected;}set{m_helper.SearchResultsButtonSelected = value;}}
		public System.Boolean ShowsSearchResultsButton {get{return m_helper.ShowsSearchResultsButton;}set{m_helper.ShowsSearchResultsButton = value;}}
		public MonoTouch.UIKit.UISearchBarPredicate ShouldBeginEditing {get{return m_helper.ShouldBeginEditing;}set{m_helper.ShouldBeginEditing = value;}}
		public MonoTouch.UIKit.UISearchBarPredicate ShouldEndEditing {get{return m_helper.ShouldEndEditing;}set{m_helper.ShouldEndEditing = value;}}
		public MonoTouch.UIKit.UISearchBarRangeEventArgs ShouldChangeTextInRange {get{return m_helper.ShouldChangeTextInRange;}set{m_helper.ShouldChangeTextInRange = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UISlider : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UISlider (UISlider element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UISlider m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UISlider();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Single Value {get{return m_helper.Value;}set{m_helper.Value = value;}}
		public System.Single MinValue {get{return m_helper.MinValue;}set{m_helper.MinValue = value;}}
		public System.Single MaxValue {get{return m_helper.MaxValue;}set{m_helper.MaxValue = value;}}
		public MonoTouch.UIKit.UIImage MinValueImage {get{return m_helper.MinValueImage;}set{m_helper.MinValueImage = value;}}
		public MonoTouch.UIKit.UIImage MaxValueImage {get{return m_helper.MaxValueImage;}set{m_helper.MaxValueImage = value;}}
		public System.Boolean Continuous {get{return m_helper.Continuous;}set{m_helper.Continuous = value;}}
		public MonoTouch.UIKit.UIImage CurrentThumbImage {get{return m_helper.CurrentThumbImage;}set{m_helper.CurrentThumbImage = value;}}
		public MonoTouch.UIKit.UIImage CurrentMinTrackImage {get{return m_helper.CurrentMinTrackImage;}set{m_helper.CurrentMinTrackImage = value;}}
		public MonoTouch.UIKit.UIImage CurrentMaxTrackImage {get{return m_helper.CurrentMaxTrackImage;}set{m_helper.CurrentMaxTrackImage = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UISwitch : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UISwitch (UISwitch element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UISwitch m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UISwitch();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Boolean On {get{return m_helper.On;}set{m_helper.On = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public MonoTouch.UIKit.UIControlContentVerticalAlignment VerticalAlignment {get{return m_helper.VerticalAlignment;}set{m_helper.VerticalAlignment = value;}}
		public MonoTouch.UIKit.UIControlContentHorizontalAlignment HorizontalAlignment {get{return m_helper.HorizontalAlignment;}set{m_helper.HorizontalAlignment = value;}}
		public MonoTouch.UIKit.UIControlState State {get{return m_helper.State;}}
		public System.Boolean Tracking {get{return m_helper.Tracking;}}
		public System.Boolean TouchInside {get{return m_helper.TouchInside;}}
		public MonoTouch.Foundation.NSSet AllTargets {get{return m_helper.AllTargets;}}
		public MonoTouch.UIKit.UIControlEvent AllControlEvents {get{return m_helper.AllControlEvents;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UITabBar : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UITabBar (UITabBar element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UITabBar m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UITabBar();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UITabBarDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public MonoTouch.UIKit.UITabBarItem[] Items {get{return m_helper.Items;}set{m_helper.Items = value;}}
		public MonoTouch.UIKit.UITabBarItem SelectedItem {get{return m_helper.SelectedItem;}set{m_helper.SelectedItem = value;}}
		public System.Boolean IsCustomizing {get{return m_helper.IsCustomizing;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIToolbar : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIToolbar (UIToolbar element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIToolbar m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIToolbar();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.UIKit.UIBarStyle BarStyle {get{return m_helper.BarStyle;}set{m_helper.BarStyle = value;}}
		public MonoTouch.UIKit.UIBarButtonItem[] Items {get{return m_helper.Items;}set{m_helper.Items = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor TintColor {get{return m_helper.TintColor;}set{m_helper.TintColor = value;}}
		public System.Boolean Translucent {get{return m_helper.Translucent;}set{m_helper.Translucent = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
	public  partial class UIWebView : UIElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UIWebView (UIWebView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.UIKit.UIWebView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UIWebView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.UIKit.UIWebViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public MonoTouch.Foundation.NSUrlRequest Request {get{return m_helper.Request;}}
		public System.Boolean CanGoBack {get{return m_helper.CanGoBack;}}
		public System.Boolean CanGoForward {get{return m_helper.CanGoForward;}}
		public System.Boolean IsLoading {get{return m_helper.IsLoading;}}
		public System.Boolean ScalesPageToFit {get{return m_helper.ScalesPageToFit;}set{m_helper.ScalesPageToFit = value;}}
		public MonoTouch.UIKit.UIDataDetectorType DataDetectorTypes {get{return m_helper.DataDetectorTypes;}set{m_helper.DataDetectorTypes = value;}}
		public System.Boolean AllowsInlineMediaPlayback {get{return m_helper.AllowsInlineMediaPlayback;}set{m_helper.AllowsInlineMediaPlayback = value;}}
		public System.Boolean MediaPlaybackRequiresUserAction {get{return m_helper.MediaPlaybackRequiresUserAction;}set{m_helper.MediaPlaybackRequiresUserAction = value;}}
		public MonoTouch.UIKit.UIWebLoaderControl ShouldStartLoad {get{return m_helper.ShouldStartLoad;}set{m_helper.ShouldStartLoad = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor BackgroundColor {get{return m_helper.BackgroundColor;}set{m_helper.BackgroundColor = value;}}
		public System.Drawing.RectangleF Bounds {get{return m_helper.Bounds;}set{m_helper.Bounds = value;}}
		public System.Boolean UserInteractionEnabled {get{return m_helper.UserInteractionEnabled;}set{m_helper.UserInteractionEnabled = value;}}
		public System.Int32 Tag {get{return m_helper.Tag;}set{m_helper.Tag = value;}}
		public MonoTouch.CoreAnimation.CALayer Layer {get{return m_helper.Layer;}}
		public System.Drawing.RectangleF Frame {get{return m_helper.Frame;}set{m_helper.Frame = value;}}
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
		#region Methods
		#endregion
	}
	
}

