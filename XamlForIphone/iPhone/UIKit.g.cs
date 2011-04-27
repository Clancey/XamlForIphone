using System;
using System.ComponentModel;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
namespace XamlForIphone
{
	public  partial class UIView : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void Add (MonoTouch.UIKit.UIView view) { m_helper.Add(view);}
		public  void AddSubviews (MonoTouch.UIKit.UIView[] views) { m_helper.AddSubviews(views);}
		public  System.Collections.IEnumerator GetEnumerator () {return  m_helper.GetEnumerator();}
		public  void AddSubview (MonoTouch.UIKit.UIView view) { m_helper.AddSubview(view);}
		public  void Draw (System.Drawing.RectangleF rect) { m_helper.Draw(rect);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.PointF point , MonoTouch.UIKit.UIFont font) {return  m_helper.DrawString(str , point , font);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.PointF point , System.Single width , MonoTouch.UIKit.UIFont font , MonoTouch.UIKit.UILineBreakMode breakMode) {return  m_helper.DrawString(str , point , width , font , breakMode);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.PointF point , System.Single width , MonoTouch.UIKit.UIFont font , System.Single fontSize , MonoTouch.UIKit.UILineBreakMode breakMode , MonoTouch.UIKit.UIBaselineAdjustment adjustment) {return  m_helper.DrawString(str , point , width , font , fontSize , breakMode , adjustment);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.PointF point , System.Single width , MonoTouch.UIKit.UIFont font , System.Single minFontSize , System.Single actualFontSize , MonoTouch.UIKit.UILineBreakMode breakMode , MonoTouch.UIKit.UIBaselineAdjustment adjustment) {return  m_helper.DrawString(str , point , width , font , minFontSize , actualFontSize , breakMode , adjustment);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.RectangleF rect , MonoTouch.UIKit.UIFont font) {return  m_helper.DrawString(str , rect , font);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.RectangleF rect , MonoTouch.UIKit.UIFont font , MonoTouch.UIKit.UILineBreakMode mode) {return  m_helper.DrawString(str , rect , font , mode);}
		public  System.Drawing.SizeF DrawString (System.String str , System.Drawing.RectangleF rect , MonoTouch.UIKit.UIFont font , MonoTouch.UIKit.UILineBreakMode mode , MonoTouch.UIKit.UITextAlignment alignment) {return  m_helper.DrawString(str , rect , font , mode , alignment);}
		public  System.Drawing.SizeF StringSize (System.String str , MonoTouch.UIKit.UIFont font) {return  m_helper.StringSize(str , font);}
		public  System.Drawing.SizeF StringSize (System.String str , MonoTouch.UIKit.UIFont font , System.Single forWidth , MonoTouch.UIKit.UILineBreakMode breakMode) {return  m_helper.StringSize(str , font , forWidth , breakMode);}
		public  System.Drawing.SizeF StringSize (System.String str , MonoTouch.UIKit.UIFont font , System.Drawing.SizeF constrainedToSize) {return  m_helper.StringSize(str , font , constrainedToSize);}
		public  System.Drawing.SizeF StringSize (System.String str , MonoTouch.UIKit.UIFont font , System.Drawing.SizeF constrainedToSize , MonoTouch.UIKit.UILineBreakMode lineBreakMode) {return  m_helper.StringSize(str , font , constrainedToSize , lineBreakMode);}
		public  MonoTouch.UIKit.UIView HitTest (System.Drawing.PointF point , MonoTouch.UIKit.UIEvent uievent) {return  m_helper.HitTest(point , uievent);}
		public  System.Boolean PointInside (System.Drawing.PointF point , MonoTouch.UIKit.UIEvent uievent) {return  m_helper.PointInside(point , uievent);}
		public  System.Drawing.PointF ConvertPointToView (System.Drawing.PointF point , MonoTouch.UIKit.UIView toView) {return  m_helper.ConvertPointToView(point , toView);}
		public  System.Drawing.PointF ConvertPointFromView (System.Drawing.PointF point , MonoTouch.UIKit.UIView fromView) {return  m_helper.ConvertPointFromView(point , fromView);}
		public  System.Drawing.RectangleF ConvertRectToView (System.Drawing.RectangleF rect , MonoTouch.UIKit.UIView toView) {return  m_helper.ConvertRectToView(rect , toView);}
		public  System.Drawing.RectangleF ConvertRectFromView (System.Drawing.RectangleF rect , MonoTouch.UIKit.UIView fromView) {return  m_helper.ConvertRectFromView(rect , fromView);}
		public  System.Drawing.SizeF SizeThatFits (System.Drawing.SizeF size) {return  m_helper.SizeThatFits(size);}
		public  void SizeToFit () { m_helper.SizeToFit();}
		public  void RemoveFromSuperview () { m_helper.RemoveFromSuperview();}
		public  void InsertSubview (MonoTouch.UIKit.UIView view , System.Int32 atIndex) { m_helper.InsertSubview(view , atIndex);}
		public  void ExchangeSubview (System.Int32 atIndex , System.Int32 withSubviewAtIndex) { m_helper.ExchangeSubview(atIndex , withSubviewAtIndex);}
		public  void InsertSubviewBelow (MonoTouch.UIKit.UIView view , MonoTouch.UIKit.UIView siblingSubview) { m_helper.InsertSubviewBelow(view , siblingSubview);}
		public  void InsertSubviewAbove (MonoTouch.UIKit.UIView view , MonoTouch.UIKit.UIView siblingSubview) { m_helper.InsertSubviewAbove(view , siblingSubview);}
		public  void BringSubviewToFront (MonoTouch.UIKit.UIView view) { m_helper.BringSubviewToFront(view);}
		public  void SendSubviewToBack (MonoTouch.UIKit.UIView view) { m_helper.SendSubviewToBack(view);}
		public  void SubviewAdded (MonoTouch.UIKit.UIView uiview) { m_helper.SubviewAdded(uiview);}
		public  void WillRemoveSubview (MonoTouch.UIKit.UIView uiview) { m_helper.WillRemoveSubview(uiview);}
		public  void WillMoveToSuperview (MonoTouch.UIKit.UIView newsuper) { m_helper.WillMoveToSuperview(newsuper);}
		public  void MovedToSuperview () { m_helper.MovedToSuperview();}
		public  void WillMoveToWindow (MonoTouch.UIKit.UIWindow window) { m_helper.WillMoveToWindow(window);}
		public  void MovedToWindow () { m_helper.MovedToWindow();}
		public  System.Boolean IsDescendantOfView (MonoTouch.UIKit.UIView view) {return  m_helper.IsDescendantOfView(view);}
		public  MonoTouch.UIKit.UIView ViewWithTag (System.Int32 tag) {return  m_helper.ViewWithTag(tag);}
		public  void SetNeedsLayout () { m_helper.SetNeedsLayout();}
		public  void LayoutIfNeeded () { m_helper.LayoutIfNeeded();}
		public  void LayoutSubviews () { m_helper.LayoutSubviews();}
		public  void SetNeedsDisplay () { m_helper.SetNeedsDisplay();}
		public  void SetNeedsDisplayInRect (System.Drawing.RectangleF rect) { m_helper.SetNeedsDisplayInRect(rect);}
		public  void AddGestureRecognizer (MonoTouch.UIKit.UIGestureRecognizer gestureRecognizer) { m_helper.AddGestureRecognizer(gestureRecognizer);}
		public  void RemoveGestureRecognizer (MonoTouch.UIKit.UIGestureRecognizer gestureRecognizer) { m_helper.RemoveGestureRecognizer(gestureRecognizer);}
		public  void DrawRect (System.Drawing.RectangleF area , MonoTouch.UIKit.UIViewPrintFormatter formatter) { m_helper.DrawRect(area , formatter);}
		#endregion
	}
	
	public  partial class MKMapView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKMapView (MKMapView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKMapView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKMapView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.MapKit.MKMapViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public MonoTouch.MapKit.MKMapType MapType {get{return m_helper.MapType;}set{m_helper.MapType = value;}}
		public MonoTouch.MapKit.MKCoordinateRegion Region {get{return m_helper.Region;}set{m_helper.Region = value;}}
		public MonoTouch.CoreLocation.CLLocationCoordinate2D CenterCoordinate {get{return m_helper.CenterCoordinate;}set{m_helper.CenterCoordinate = value;}}
		public System.Boolean ZoomEnabled {get{return m_helper.ZoomEnabled;}set{m_helper.ZoomEnabled = value;}}
		public System.Boolean ScrollEnabled {get{return m_helper.ScrollEnabled;}set{m_helper.ScrollEnabled = value;}}
		public System.Boolean ShowsUserLocation {get{return m_helper.ShowsUserLocation;}set{m_helper.ShowsUserLocation = value;}}
		public MonoTouch.MapKit.MKUserLocation UserLocation {get{return m_helper.UserLocation;}}
		public System.Boolean UserLocationVisible {get{return m_helper.UserLocationVisible;}}
		public MonoTouch.Foundation.NSObject[] Annotations {get{return m_helper.Annotations;}}
		public MonoTouch.Foundation.NSObject[] SelectedAnnotations {get{return m_helper.SelectedAnnotations;}set{m_helper.SelectedAnnotations = value;}}
		public System.Drawing.RectangleF AnnotationVisibleRect {get{return m_helper.AnnotationVisibleRect;}}
		public MonoTouch.Foundation.NSObject[] Overlays {get{return m_helper.Overlays;}}
		public MonoTouch.MapKit.MKMapRect visibleMapRect {get{return m_helper.visibleMapRect;}set{m_helper.visibleMapRect = value;}}
		public MonoTouch.MapKit.MKMapViewAnnotation GetViewForAnnotation {get{return m_helper.GetViewForAnnotation;}set{m_helper.GetViewForAnnotation = value;}}
		public MonoTouch.MapKit.MKMapViewOverlay GetViewForOverlay {get{return m_helper.GetViewForOverlay;}set{m_helper.GetViewForOverlay = value;}}
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
		#region Events
		public event EventHandler RegionWillChange;
		public event EventHandler RegionChanged;
		public event EventHandler WillStartLoadingMap;
		public event EventHandler MapLoaded;
		public event EventHandler LoadingMapFailed;
		public event EventHandler DidAddAnnotationViews;
		public event EventHandler CalloutAccessoryControlTapped;
		public event EventHandler ChangedDragState;
		public event EventHandler DidAddOverlayViews;
		public event EventHandler DidSelectAnnotationView;
		public event EventHandler DidFailToLocateUser;
		public event EventHandler DidDeselectAnnotationView;
		public event EventHandler WillStartLocatingUser;
		public event EventHandler DidStopLocatingUser;
		public event EventHandler DidUpdateUserLocation;
		internal override void setupEvents ()
		{
			m_helper.RegionWillChange+=  delegate (System.Object sender,MonoTouch.MapKit.MKMapViewChangeEventArgs e){
			if(RegionWillChange != null)
			RegionWillChange(sender,e);
			};
			m_helper.RegionChanged+=  delegate (System.Object sender,MonoTouch.MapKit.MKMapViewChangeEventArgs e){
			if(RegionChanged != null)
			RegionChanged(sender,e);
			};
			m_helper.WillStartLoadingMap+=  delegate (System.Object sender,System.EventArgs e){
			if(WillStartLoadingMap != null)
			WillStartLoadingMap(sender,e);
			};
			m_helper.MapLoaded+=  delegate (System.Object sender,System.EventArgs e){
			if(MapLoaded != null)
			MapLoaded(sender,e);
			};
			m_helper.LoadingMapFailed+=  delegate (System.Object sender,MonoTouch.Foundation.NSErrorEventArgs e){
			if(LoadingMapFailed != null)
			LoadingMapFailed(sender,e);
			};
			m_helper.DidAddAnnotationViews+=  delegate (System.Object sender,MonoTouch.MapKit.MKMapViewAnnotationEventArgs e){
			if(DidAddAnnotationViews != null)
			DidAddAnnotationViews(sender,e);
			};
			m_helper.CalloutAccessoryControlTapped+=  delegate (System.Object sender,MonoTouch.MapKit.MKMapViewAccessoryTappedEventArgs e){
			if(CalloutAccessoryControlTapped != null)
			CalloutAccessoryControlTapped(sender,e);
			};
			m_helper.ChangedDragState+=  delegate (System.Object sender,MonoTouch.MapKit.MKMapViewDragStateEventArgs e){
			if(ChangedDragState != null)
			ChangedDragState(sender,e);
			};
			m_helper.DidAddOverlayViews+=  delegate (System.Object sender,MonoTouch.MapKit.MKOverlayViewsEventArgs e){
			if(DidAddOverlayViews != null)
			DidAddOverlayViews(sender,e);
			};
			m_helper.DidSelectAnnotationView+=  delegate (System.Object sender,MonoTouch.MapKit.MKAnnotationViewEventArgs e){
			if(DidSelectAnnotationView != null)
			DidSelectAnnotationView(sender,e);
			};
			m_helper.DidFailToLocateUser+=  delegate (System.Object sender,MonoTouch.Foundation.NSErrorEventArgs e){
			if(DidFailToLocateUser != null)
			DidFailToLocateUser(sender,e);
			};
			m_helper.DidDeselectAnnotationView+=  delegate (System.Object sender,MonoTouch.MapKit.MKAnnotationViewEventArgs e){
			if(DidDeselectAnnotationView != null)
			DidDeselectAnnotationView(sender,e);
			};
			m_helper.WillStartLocatingUser+=  delegate (System.Object sender,System.EventArgs e){
			if(WillStartLocatingUser != null)
			WillStartLocatingUser(sender,e);
			};
			m_helper.DidStopLocatingUser+=  delegate (System.Object sender,System.EventArgs e){
			if(DidStopLocatingUser != null)
			DidStopLocatingUser(sender,e);
			};
			m_helper.DidUpdateUserLocation+=  delegate (System.Object sender,MonoTouch.MapKit.MKUserLocationEventArgs e){
			if(DidUpdateUserLocation != null)
			DidUpdateUserLocation(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void AddAnnotation (MonoTouch.MapKit.MKAnnotation annotation) { m_helper.AddAnnotation(annotation);}
		public  void AddAnnotation (MonoTouch.MapKit.MKAnnotation[] annotations) { m_helper.AddAnnotation(annotations);}
		public  void AddPlacemark (MonoTouch.MapKit.MKPlacemark placemark) { m_helper.AddPlacemark(placemark);}
		public  void AddAnnotation (MonoTouch.MapKit.MKPlacemark[] placemarks) { m_helper.AddAnnotation(placemarks);}
		public  void SetRegion (MonoTouch.MapKit.MKCoordinateRegion region , System.Boolean animated) { m_helper.SetRegion(region , animated);}
		public  void SetCenterCoordinate (MonoTouch.CoreLocation.CLLocationCoordinate2D coordinate , System.Boolean animated) { m_helper.SetCenterCoordinate(coordinate , animated);}
		public  MonoTouch.MapKit.MKCoordinateRegion RegionThatFits (MonoTouch.MapKit.MKCoordinateRegion region) {return  m_helper.RegionThatFits(region);}
		public  System.Drawing.PointF ConvertCoordinate (MonoTouch.CoreLocation.CLLocationCoordinate2D coordinate , MonoTouch.UIKit.UIView toPointToView) {return  m_helper.ConvertCoordinate(coordinate , toPointToView);}
		public  MonoTouch.CoreLocation.CLLocationCoordinate2D ConvertPoint (System.Drawing.PointF point , MonoTouch.UIKit.UIView toCoordinateFromView) {return  m_helper.ConvertPoint(point , toCoordinateFromView);}
		public  System.Drawing.RectangleF ConvertRegion (MonoTouch.MapKit.MKCoordinateRegion region , MonoTouch.UIKit.UIView toRectToView) {return  m_helper.ConvertRegion(region , toRectToView);}
		public  MonoTouch.MapKit.MKCoordinateRegion ConvertRect (System.Drawing.RectangleF rect , MonoTouch.UIKit.UIView toRegiontFromView) {return  m_helper.ConvertRect(rect , toRegiontFromView);}
		public  void AddAnnotationObject (MonoTouch.Foundation.NSObject annotation) { m_helper.AddAnnotationObject(annotation);}
		public  void AddAnnotationObjects (MonoTouch.Foundation.NSObject[] annotations) { m_helper.AddAnnotationObjects(annotations);}
		public  void RemoveAnnotation (MonoTouch.MapKit.MKAnnotation annotation) { m_helper.RemoveAnnotation(annotation);}
		public  void RemoveAnnotations (MonoTouch.MapKit.MKAnnotation[] annotations) { m_helper.RemoveAnnotations(annotations);}
		public  MonoTouch.MapKit.MKAnnotationView ViewForAnnotation (MonoTouch.MapKit.MKAnnotation annotation) {return  m_helper.ViewForAnnotation(annotation);}
		public  MonoTouch.MapKit.MKAnnotationView DequeueReusableAnnotation (System.String withViewIdentifier) {return  m_helper.DequeueReusableAnnotation(withViewIdentifier);}
		public  void SelectAnnotation (MonoTouch.MapKit.MKAnnotation annotation , System.Boolean animated) { m_helper.SelectAnnotation(annotation , animated);}
		public  void DeselectAnnotation (MonoTouch.MapKit.MKAnnotation annotation , System.Boolean animated) { m_helper.DeselectAnnotation(annotation , animated);}
		public  void AddOverlay (MonoTouch.Foundation.NSObject overlay) { m_helper.AddOverlay(overlay);}
		public  void AddOverlays (MonoTouch.Foundation.NSObject[] overlays) { m_helper.AddOverlays(overlays);}
		public  void RemoveOverlay (MonoTouch.Foundation.NSObject overlay) { m_helper.RemoveOverlay(overlay);}
		public  void RemoveOverlays (MonoTouch.Foundation.NSObject[] overlays) { m_helper.RemoveOverlays(overlays);}
		public  void InsertOverlay (MonoTouch.Foundation.NSObject overlay , System.Int32 index) { m_helper.InsertOverlay(overlay , index);}
		public  void InsertOverlayAbove (MonoTouch.Foundation.NSObject overlay , MonoTouch.Foundation.NSObject sibling) { m_helper.InsertOverlayAbove(overlay , sibling);}
		public  void InsertOverlayBelow (MonoTouch.Foundation.NSObject overlay , MonoTouch.Foundation.NSObject sibling) { m_helper.InsertOverlayBelow(overlay , sibling);}
		public  void ExchangeOverlays (System.Int32 index1 , System.Int32 index2) { m_helper.ExchangeOverlays(index1 , index2);}
		public  MonoTouch.MapKit.MKMapRect MapRectThatFits (MonoTouch.MapKit.MKMapRect mapRect) {return  m_helper.MapRectThatFits(mapRect);}
		public  void SetVisibleMapRect (MonoTouch.MapKit.MKMapRect mapRect , MonoTouch.UIKit.UIEdgeInsets edgePadding , System.Boolean animate) { m_helper.SetVisibleMapRect(mapRect , edgePadding , animate);}
		public  void SetVisibleMapRect (MonoTouch.MapKit.MKMapRect mapRect , System.Boolean animate) { m_helper.SetVisibleMapRect(mapRect , animate);}
		public  MonoTouch.MapKit.MKMapRect MapRectThatFits (MonoTouch.MapKit.MKMapRect mapRect , MonoTouch.UIKit.UIEdgeInsets edgePadding) {return  m_helper.MapRectThatFits(mapRect , edgePadding);}
		public  MonoTouch.MapKit.MKOverlayView ViewForOverlay (MonoTouch.Foundation.NSObject overlay) {return  m_helper.ViewForOverlay(overlay);}
		public  MonoTouch.Foundation.NSSet GetAnnotations (MonoTouch.MapKit.MKMapRect mapRect) {return  m_helper.GetAnnotations(mapRect);}
		#endregion
	}
	
	public  partial class MKOverlayView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKOverlayView (MKOverlayView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKOverlayView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKOverlayView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject Overlay {get{return m_helper.Overlay;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  System.Drawing.PointF PointForMapPoint (MonoTouch.MapKit.MKMapPoint mapPoint) {return  m_helper.PointForMapPoint(mapPoint);}
		public  MonoTouch.MapKit.MKMapPoint MapPointForPoint (System.Drawing.PointF point) {return  m_helper.MapPointForPoint(point);}
		public  System.Drawing.RectangleF RectForMapRect (MonoTouch.MapKit.MKMapRect mapRect) {return  m_helper.RectForMapRect(mapRect);}
		public  MonoTouch.MapKit.MKMapRect MapRectForRect (System.Drawing.RectangleF rect) {return  m_helper.MapRectForRect(rect);}
		public  System.Boolean CanDrawMapRect (MonoTouch.MapKit.MKMapRect mapRect , System.Single zoomScale) {return  m_helper.CanDrawMapRect(mapRect , zoomScale);}
		public  void DrawMapRect (MonoTouch.MapKit.MKMapRect mapRect , System.Single zoomScale , MonoTouch.CoreGraphics.CGContext context) { m_helper.DrawMapRect(mapRect , zoomScale , context);}
		public  void SetNeedsDisplay (MonoTouch.MapKit.MKMapRect mapRect) { m_helper.SetNeedsDisplay(mapRect);}
		public  void SetNeedsDisplay (MonoTouch.MapKit.MKMapRect mapRect , System.Single zoomScale) { m_helper.SetNeedsDisplay(mapRect , zoomScale);}
		#endregion
	}
	
	public  partial class UIActionSheet : FrameworkElement
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
		#region Events
		public event EventHandler Clicked;
		public event EventHandler Canceled;
		public event EventHandler WillPresent;
		public event EventHandler Presented;
		public event EventHandler WillDismiss;
		public event EventHandler Dismissed;
		internal override void setupEvents ()
		{
			m_helper.Clicked+=  delegate (System.Object sender,MonoTouch.UIKit.UIButtonEventArgs e){
			if(Clicked != null)
			Clicked(sender,e);
			};
			m_helper.Canceled+=  delegate (System.Object sender,System.EventArgs e){
			if(Canceled != null)
			Canceled(sender,e);
			};
			m_helper.WillPresent+=  delegate (System.Object sender,System.EventArgs e){
			if(WillPresent != null)
			WillPresent(sender,e);
			};
			m_helper.Presented+=  delegate (System.Object sender,System.EventArgs e){
			if(Presented != null)
			Presented(sender,e);
			};
			m_helper.WillDismiss+=  delegate (System.Object sender,MonoTouch.UIKit.UIButtonEventArgs e){
			if(WillDismiss != null)
			WillDismiss(sender,e);
			};
			m_helper.Dismissed+=  delegate (System.Object sender,MonoTouch.UIKit.UIButtonEventArgs e){
			if(Dismissed != null)
			Dismissed(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void Add (System.String name) { m_helper.Add(name);}
		public  System.Collections.IEnumerator GetEnumerator () {return  m_helper.GetEnumerator();}
		public  System.Int32 AddButton (System.String title) {return  m_helper.AddButton(title);}
		public  System.String ButtonTitle (System.Int32 index) {return  m_helper.ButtonTitle(index);}
		public  void ShowFromToolbar (MonoTouch.UIKit.UIToolbar view) { m_helper.ShowFromToolbar(view);}
		public  void ShowFromTabBar (MonoTouch.UIKit.UITabBar view) { m_helper.ShowFromTabBar(view);}
		public  void ShowInView (MonoTouch.UIKit.UIView view) { m_helper.ShowInView(view);}
		public  void DismissWithClickedButtonIndex (System.Int32 buttonIndex , System.Boolean animated) { m_helper.DismissWithClickedButtonIndex(buttonIndex , animated);}
		public  void ShowFrom (MonoTouch.UIKit.UIBarButtonItem item , System.Boolean animated) { m_helper.ShowFrom(item , animated);}
		public  void ShowFrom (System.Drawing.RectangleF rect , MonoTouch.UIKit.UIView inView , System.Boolean animated) { m_helper.ShowFrom(rect , inView , animated);}
		#endregion
	}
	
	public  partial class UIAlertView : FrameworkElement
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
		#region Events
		public event EventHandler Clicked;
		public event EventHandler Canceled;
		public event EventHandler WillPresent;
		public event EventHandler Presented;
		public event EventHandler WillDismiss;
		public event EventHandler Dismissed;
		internal override void setupEvents ()
		{
			m_helper.Clicked+=  delegate (System.Object sender,MonoTouch.UIKit.UIButtonEventArgs e){
			if(Clicked != null)
			Clicked(sender,e);
			};
			m_helper.Canceled+=  delegate (System.Object sender,System.EventArgs e){
			if(Canceled != null)
			Canceled(sender,e);
			};
			m_helper.WillPresent+=  delegate (System.Object sender,System.EventArgs e){
			if(WillPresent != null)
			WillPresent(sender,e);
			};
			m_helper.Presented+=  delegate (System.Object sender,System.EventArgs e){
			if(Presented != null)
			Presented(sender,e);
			};
			m_helper.WillDismiss+=  delegate (System.Object sender,MonoTouch.UIKit.UIButtonEventArgs e){
			if(WillDismiss != null)
			WillDismiss(sender,e);
			};
			m_helper.Dismissed+=  delegate (System.Object sender,MonoTouch.UIKit.UIButtonEventArgs e){
			if(Dismissed != null)
			Dismissed(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  System.Int32 AddButton (System.String title) {return  m_helper.AddButton(title);}
		public  System.String ButtonTitle (System.Int32 index) {return  m_helper.ButtonTitle(index);}
		public  void Show () { m_helper.Show();}
		public  void DismissWithClickedButtonIndex (System.Int32 index , System.Boolean animated) { m_helper.DismissWithClickedButtonIndex(index , animated);}
		#endregion
	}
	
	public  partial class UIControl : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void AddTarget (System.EventHandler notification , MonoTouch.UIKit.UIControlEvent events) { m_helper.AddTarget(notification , events);}
		public  void RemoveTarget (System.EventHandler notification , MonoTouch.UIKit.UIControlEvent events) { m_helper.RemoveTarget(notification , events);}
		public  System.Boolean BeginTracking (MonoTouch.UIKit.UITouch uitouch , MonoTouch.UIKit.UIEvent uievent) {return  m_helper.BeginTracking(uitouch , uievent);}
		public  System.Boolean ContinueTracking (MonoTouch.UIKit.UITouch uitouch , MonoTouch.UIKit.UIEvent uievent) {return  m_helper.ContinueTracking(uitouch , uievent);}
		public  void EndTracking (MonoTouch.UIKit.UITouch uitouch , MonoTouch.UIKit.UIEvent uievent) { m_helper.EndTracking(uitouch , uievent);}
		public  void CancelTracking (MonoTouch.UIKit.UIEvent uievent) { m_helper.CancelTracking(uievent);}
		public  void AddTarget (MonoTouch.Foundation.NSObject target , MonoTouch.ObjCRuntime.Selector sel , MonoTouch.UIKit.UIControlEvent events) { m_helper.AddTarget(target , sel , events);}
		public  void RemoveTarget (MonoTouch.Foundation.NSObject target , MonoTouch.ObjCRuntime.Selector sel , MonoTouch.UIKit.UIControlEvent events) { m_helper.RemoveTarget(target , sel , events);}
		public  System.String[] GetActions (MonoTouch.Foundation.NSObject target , MonoTouch.UIKit.UIControlEvent events) {return  m_helper.GetActions(target , events);}
		public  void SendAction (MonoTouch.ObjCRuntime.Selector action , MonoTouch.Foundation.NSObject target , MonoTouch.UIKit.UIEvent uievent) { m_helper.SendAction(action , target , uievent);}
		public  void SendActionForControlEvents (MonoTouch.UIKit.UIControlEvent events) { m_helper.SendActionForControlEvents(events);}
		#endregion
	}
	
	public  partial class UIPickerView : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  System.Int32 RowsInComponent (System.Int32 component) {return  m_helper.RowsInComponent(component);}
		public  System.Drawing.SizeF RowSizeForComponent (System.Int32 component) {return  m_helper.RowSizeForComponent(component);}
		public  MonoTouch.UIKit.UIView ViewFor (System.Int32 row , System.Int32 component) {return  m_helper.ViewFor(row , component);}
		public  void ReloadAllComponents () { m_helper.ReloadAllComponents();}
		public  void ReloadComponent (System.Int32 component) { m_helper.ReloadComponent(component);}
		public  void Select (System.Int32 row , System.Int32 component , System.Boolean animated) { m_helper.Select(row , component , animated);}
		public  System.Int32 SelectedRowInComponent (System.Int32 component) {return  m_helper.SelectedRowInComponent(component);}
		#endregion
	}
	
	public  partial class UISegmentedControl : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void InsertSegment (System.String title , System.Int32 pos , System.Boolean animated) { m_helper.InsertSegment(title , pos , animated);}
		public  void InsertSegment (MonoTouch.UIKit.UIImage image , System.Int32 pos , System.Boolean animated) { m_helper.InsertSegment(image , pos , animated);}
		public  void RemoveSegmentAtIndex (System.Int32 segment , System.Boolean animated) { m_helper.RemoveSegmentAtIndex(segment , animated);}
		public  void RemoveAllSegments () { m_helper.RemoveAllSegments();}
		public  void SetTitle (System.String title , System.Int32 segment) { m_helper.SetTitle(title , segment);}
		public  System.String TitleAt (System.Int32 segment) {return  m_helper.TitleAt(segment);}
		public  void SetImage (MonoTouch.UIKit.UIImage image , System.Int32 segment) { m_helper.SetImage(image , segment);}
		public  MonoTouch.UIKit.UIImage ImageAt (System.Int32 segment) {return  m_helper.ImageAt(segment);}
		public  void SetWidth (System.Single width , System.Int32 segment) { m_helper.SetWidth(width , segment);}
		public  System.Single SegmentWidth (System.Int32 segment) {return  m_helper.SegmentWidth(segment);}
		public  void SetContentOffset (System.Drawing.SizeF offset , System.Int32 segment) { m_helper.SetContentOffset(offset , segment);}
		public  System.Drawing.SizeF GetContentOffset (System.Int32 segment) {return  m_helper.GetContentOffset(segment);}
		public  void SetEnabled (System.Boolean enabled , System.Int32 segment) { m_helper.SetEnabled(enabled , segment);}
		public  System.Boolean IsEnabled (System.Int32 segment) {return  m_helper.IsEnabled(segment);}
		#endregion
	}
	
	public  partial class UITableView : FrameworkElement
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
		#region Events
		public event EventHandler Scrolled;
		public event EventHandler DraggingStarted;
		public event EventHandler DraggingEnded;
		public event EventHandler DecelerationStarted;
		public event EventHandler DecelerationEnded;
		public event EventHandler ScrollAnimationEnded;
		public event EventHandler ScrolledToTop;
		public event EventHandler ZoomingEnded;
		public event EventHandler DidZoom;
		public event EventHandler ZoomingStarted;
		internal override void setupEvents ()
		{
			m_helper.Scrolled+=  delegate (System.Object sender,System.EventArgs e){
			if(Scrolled != null)
			Scrolled(sender,e);
			};
			m_helper.DraggingStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DraggingStarted != null)
			DraggingStarted(sender,e);
			};
			m_helper.DraggingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.DraggingEventArgs e){
			if(DraggingEnded != null)
			DraggingEnded(sender,e);
			};
			m_helper.DecelerationStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationStarted != null)
			DecelerationStarted(sender,e);
			};
			m_helper.DecelerationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationEnded != null)
			DecelerationEnded(sender,e);
			};
			m_helper.ScrollAnimationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrollAnimationEnded != null)
			ScrollAnimationEnded(sender,e);
			};
			m_helper.ScrolledToTop+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrolledToTop != null)
			ScrolledToTop(sender,e);
			};
			m_helper.ZoomingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.ZoomingEndedEventArgs e){
			if(ZoomingEnded != null)
			ZoomingEnded(sender,e);
			};
			m_helper.DidZoom+=  delegate (System.Object sender,System.EventArgs e){
			if(DidZoom != null)
			DidZoom(sender,e);
			};
			m_helper.ZoomingStarted+=  delegate (System.Object sender,MonoTouch.UIKit.UIScrollViewZoomingEventArgs e){
			if(ZoomingStarted != null)
			ZoomingStarted(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void ReloadData () { m_helper.ReloadData();}
		public  void ReloadSectionIndexTitles () { m_helper.ReloadSectionIndexTitles();}
		public  System.Int32 NumberOfSections () {return  m_helper.NumberOfSections();}
		public  System.Int32 NumberOfRowsInSection (System.Int32 section) {return  m_helper.NumberOfRowsInSection(section);}
		public  System.Drawing.RectangleF RectForSection (System.Int32 section) {return  m_helper.RectForSection(section);}
		public  System.Drawing.RectangleF RectForHeaderInSection (System.Int32 section) {return  m_helper.RectForHeaderInSection(section);}
		public  System.Drawing.RectangleF RectForFooterInSection (System.Int32 section) {return  m_helper.RectForFooterInSection(section);}
		public  System.Drawing.RectangleF RectForRowAtIndexPath (MonoTouch.Foundation.NSIndexPath indexPath) {return  m_helper.RectForRowAtIndexPath(indexPath);}
		public  MonoTouch.Foundation.NSIndexPath IndexPathForRowAtPoint (System.Drawing.PointF point) {return  m_helper.IndexPathForRowAtPoint(point);}
		public  MonoTouch.Foundation.NSIndexPath IndexPathForCell (MonoTouch.UIKit.UITableViewCell cell) {return  m_helper.IndexPathForCell(cell);}
		public  MonoTouch.UIKit.UITableViewCell CellAt (MonoTouch.Foundation.NSIndexPath ns) {return  m_helper.CellAt(ns);}
		public  void ScrollToRow (MonoTouch.Foundation.NSIndexPath indexPath , MonoTouch.UIKit.UITableViewScrollPosition atScrollPosition , System.Boolean animated) { m_helper.ScrollToRow(indexPath , atScrollPosition , animated);}
		public  void ScrollToNearestSelected (MonoTouch.UIKit.UITableViewScrollPosition atScrollPosition , System.Boolean animated) { m_helper.ScrollToNearestSelected(atScrollPosition , animated);}
		public  void BeginUpdates () { m_helper.BeginUpdates();}
		public  void EndUpdates () { m_helper.EndUpdates();}
		public  void InsertSections (MonoTouch.Foundation.NSIndexSet sections , MonoTouch.UIKit.UITableViewRowAnimation withRowAnimation) { m_helper.InsertSections(sections , withRowAnimation);}
		public  void DeleteSections (MonoTouch.Foundation.NSIndexSet sections , MonoTouch.UIKit.UITableViewRowAnimation withRowAnimation) { m_helper.DeleteSections(sections , withRowAnimation);}
		public  void ReloadSections (MonoTouch.Foundation.NSIndexSet sections , MonoTouch.UIKit.UITableViewRowAnimation withRowAnimation) { m_helper.ReloadSections(sections , withRowAnimation);}
		public  void InsertRows (MonoTouch.Foundation.NSIndexPath[] atIndexPaths , MonoTouch.UIKit.UITableViewRowAnimation withRowAnimation) { m_helper.InsertRows(atIndexPaths , withRowAnimation);}
		public  void DeleteRows (MonoTouch.Foundation.NSIndexPath[] atIndexPaths , MonoTouch.UIKit.UITableViewRowAnimation withRowAnimation) { m_helper.DeleteRows(atIndexPaths , withRowAnimation);}
		public  void ReloadRows (MonoTouch.Foundation.NSIndexPath[] atIndexPaths , MonoTouch.UIKit.UITableViewRowAnimation withRowAnimation) { m_helper.ReloadRows(atIndexPaths , withRowAnimation);}
		public  void SetEditing (System.Boolean editing , System.Boolean animated) { m_helper.SetEditing(editing , animated);}
		public  void SelectRow (MonoTouch.Foundation.NSIndexPath indexPath , System.Boolean animated , MonoTouch.UIKit.UITableViewScrollPosition scrollPosition) { m_helper.SelectRow(indexPath , animated , scrollPosition);}
		public  void DeselectRow (MonoTouch.Foundation.NSIndexPath indexPath , System.Boolean animated) { m_helper.DeselectRow(indexPath , animated);}
		public  MonoTouch.UIKit.UITableViewCell DequeueReusableCell (System.String identifier) {return  m_helper.DequeueReusableCell(identifier);}
		public  MonoTouch.UIKit.UITableViewCell DequeueReusableCell (MonoTouch.Foundation.NSString identifier) {return  m_helper.DequeueReusableCell(identifier);}
		#endregion
	}
	
	public  partial class UITableViewCell : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void PrepareForReuse () { m_helper.PrepareForReuse();}
		public  void SetSelected (System.Boolean selected , System.Boolean animated) { m_helper.SetSelected(selected , animated);}
		public  void SetHighlighted (System.Boolean highlighted , System.Boolean animated) { m_helper.SetHighlighted(highlighted , animated);}
		public  void SetEditing (System.Boolean editing , System.Boolean animated) { m_helper.SetEditing(editing , animated);}
		public  void WillTransitionToState (MonoTouch.UIKit.UITableViewCellState mask) { m_helper.WillTransitionToState(mask);}
		public  void DidTransitionToState (MonoTouch.UIKit.UITableViewCellState mask) { m_helper.DidTransitionToState(mask);}
		#endregion
	}
	
	public  partial class UITextField : FrameworkElement
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
		#region Events
		public event EventHandler Started;
		public event EventHandler Ended;
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.Started+=  delegate (System.Object sender,System.EventArgs e){
			if(Started != null)
			Started(sender,e);
			};
			m_helper.Ended+=  delegate (System.Object sender,System.EventArgs e){
			if(Ended != null)
			Ended(sender,e);
			};
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  System.Drawing.RectangleF BorderRect (System.Drawing.RectangleF forBounds) {return  m_helper.BorderRect(forBounds);}
		public  System.Drawing.RectangleF TextRect (System.Drawing.RectangleF forBounds) {return  m_helper.TextRect(forBounds);}
		public  System.Drawing.RectangleF PlaceholderRect (System.Drawing.RectangleF forBounds) {return  m_helper.PlaceholderRect(forBounds);}
		public  System.Drawing.RectangleF EditingRect (System.Drawing.RectangleF forBounds) {return  m_helper.EditingRect(forBounds);}
		public  System.Drawing.RectangleF ClearButtonRect (System.Drawing.RectangleF forBounds) {return  m_helper.ClearButtonRect(forBounds);}
		public  System.Drawing.RectangleF LeftViewRect (System.Drawing.RectangleF forBounds) {return  m_helper.LeftViewRect(forBounds);}
		public  System.Drawing.RectangleF RightViewRect (System.Drawing.RectangleF forBounds) {return  m_helper.RightViewRect(forBounds);}
		public  void DrawText (System.Drawing.RectangleF rect) { m_helper.DrawText(rect);}
		public  void DrawPlaceholder (System.Drawing.RectangleF rect) { m_helper.DrawPlaceholder(rect);}
		#endregion
	}
	
	public  partial class UITextView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.UIKit.UITextView (UITextView element)
		{
			return element.m_helper;
		}
		MonoTouch.UIKit.UIButton dismiss;
		internal new MonoTouch.UIKit.UITextView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.UIKit.UITextView();
			m_helper.Editable = true;
			var accessFrame = new RectangleF(0, 0, 300, 25);
			var inputAccessoryView =new MonoTouch.UIKit.UIView(accessFrame);;
			//inputAccessoryView.BackgroundColor = MonoTouch.UIKit.UIColor.Blue;
			dismiss = MonoTouch.UIKit.UIButton.FromType(MonoTouch.UIKit.UIButtonType.RoundedRect);
			dismiss.Frame = new System.Drawing.RectangleF(0, 0, 158, 25);
			
				dismiss.SetTitle("Dismiss",MonoTouch.UIKit.UIControlState.Normal);
				dismiss.TouchDown += delegate {
					m_helper.BecomeFirstResponder();
					m_helper.ResignFirstResponder();
				};
			inputAccessoryView.AddSubview(dismiss);
			
			m_helper.InputAccessoryView = inputAccessoryView;
			//m_helper.Started += delegate {
				//dismiss = MonoTouch.UIKit.UIButton.FromType(MonoTouch.UIKit.UIButtonType.InfoDark);
				//m_helper.InputView = dismiss;
			
			//};
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
		#region Events
		public event EventHandler Started;
		public event EventHandler Ended;
		public event EventHandler Changed;
		public event EventHandler SelectionChanged;
		public event EventHandler Scrolled;
		public event EventHandler DraggingStarted;
		public event EventHandler DraggingEnded;
		public event EventHandler DecelerationStarted;
		public event EventHandler DecelerationEnded;
		public event EventHandler ScrollAnimationEnded;
		public event EventHandler ScrolledToTop;
		public event EventHandler ZoomingEnded;
		public event EventHandler DidZoom;
		public event EventHandler ZoomingStarted;
		//public event EventHandler Scrolled;
		//public event EventHandler DraggingStarted;
		//public event EventHandler DraggingEnded;
		//public event EventHandler DecelerationStarted;
		//public event EventHandler DecelerationEnded;
		//public event EventHandler ScrollAnimationEnded;
		//public event EventHandler ScrolledToTop;
		//public event EventHandler ZoomingEnded;
		//public event EventHandler DidZoom;
		//public event EventHandler ZoomingStarted;
		internal override void setupEvents ()
		{
			m_helper.Started+=  delegate (System.Object sender,System.EventArgs e){
			if(Started != null)
			Started(sender,e);
			};
			m_helper.Ended+=  delegate (System.Object sender,System.EventArgs e){
			if(Ended != null)
			Ended(sender,e);
			};
			m_helper.Changed+=  delegate (System.Object sender,System.EventArgs e){
			if(Changed != null)
			Changed(sender,e);
			};
			m_helper.SelectionChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(SelectionChanged != null)
			SelectionChanged(sender,e);
			};
			m_helper.Scrolled+=  delegate (System.Object sender,System.EventArgs e){
			if(Scrolled != null)
			Scrolled(sender,e);
			};
			m_helper.DraggingStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DraggingStarted != null)
			DraggingStarted(sender,e);
			};
			m_helper.DraggingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.DraggingEventArgs e){
			if(DraggingEnded != null)
			DraggingEnded(sender,e);
			};
			m_helper.DecelerationStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationStarted != null)
			DecelerationStarted(sender,e);
			};
			m_helper.DecelerationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationEnded != null)
			DecelerationEnded(sender,e);
			};
			m_helper.ScrollAnimationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrollAnimationEnded != null)
			ScrollAnimationEnded(sender,e);
			};
			m_helper.ScrolledToTop+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrolledToTop != null)
			ScrolledToTop(sender,e);
			};
			m_helper.ZoomingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.ZoomingEndedEventArgs e){
			if(ZoomingEnded != null)
			ZoomingEnded(sender,e);
			};
			m_helper.DidZoom+=  delegate (System.Object sender,System.EventArgs e){
			if(DidZoom != null)
			DidZoom(sender,e);
			};
			m_helper.ZoomingStarted+=  delegate (System.Object sender,MonoTouch.UIKit.UIScrollViewZoomingEventArgs e){
			if(ZoomingStarted != null)
			ZoomingStarted(sender,e);
			};
			m_helper.Scrolled+=  delegate (System.Object sender,System.EventArgs e){
			if(Scrolled != null)
			Scrolled(sender,e);
			};
			m_helper.DraggingStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DraggingStarted != null)
			DraggingStarted(sender,e);
			};
			m_helper.DraggingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.DraggingEventArgs e){
			if(DraggingEnded != null)
			DraggingEnded(sender,e);
			};
			m_helper.DecelerationStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationStarted != null)
			DecelerationStarted(sender,e);
			};
			m_helper.DecelerationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationEnded != null)
			DecelerationEnded(sender,e);
			};
			m_helper.ScrollAnimationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrollAnimationEnded != null)
			ScrollAnimationEnded(sender,e);
			};
			m_helper.ScrolledToTop+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrolledToTop != null)
			ScrolledToTop(sender,e);
			};
			m_helper.ZoomingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.ZoomingEndedEventArgs e){
			if(ZoomingEnded != null)
			ZoomingEnded(sender,e);
			};
			m_helper.DidZoom+=  delegate (System.Object sender,System.EventArgs e){
			if(DidZoom != null)
			DidZoom(sender,e);
			};
			m_helper.ZoomingStarted+=  delegate (System.Object sender,MonoTouch.UIKit.UIScrollViewZoomingEventArgs e){
			if(ZoomingStarted != null)
			ZoomingStarted(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void ScrollRangeToVisible (MonoTouch.Foundation.NSRange range) { m_helper.ScrollRangeToVisible(range);}
		#endregion
	}
	
	public  partial class UIWindow : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void MakeKeyAndVisible () { m_helper.MakeKeyAndVisible();}
		public  void MakeKeyWindow () { m_helper.MakeKeyWindow();}
		public  void BecomeKeyWindow () { m_helper.BecomeKeyWindow();}
		public  void ResignKeyWindow () { m_helper.ResignKeyWindow();}
		public  System.Drawing.PointF ConvertPointFromWindow (System.Drawing.PointF point , MonoTouch.UIKit.UIWindow window) {return  m_helper.ConvertPointFromWindow(point , window);}
		public  System.Drawing.PointF ConvertPointToWindow (System.Drawing.PointF point , MonoTouch.UIKit.UIWindow window) {return  m_helper.ConvertPointToWindow(point , window);}
		public  System.Drawing.RectangleF ConvertRectFromWindow (System.Drawing.RectangleF rect , MonoTouch.UIKit.UIWindow window) {return  m_helper.ConvertRectFromWindow(rect , window);}
		public  System.Drawing.RectangleF ConvertRectToWindow (System.Drawing.RectangleF rect , MonoTouch.UIKit.UIWindow window) {return  m_helper.ConvertRectToWindow(rect , window);}
		public  void SendEvent (MonoTouch.UIKit.UIEvent evt) { m_helper.SendEvent(evt);}
		#endregion
	}
	
	public  partial class MPVolumeView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MediaPlayer.MPVolumeView (MPVolumeView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MediaPlayer.MPVolumeView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MediaPlayer.MPVolumeView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.Boolean ShowsRouteButton {get{return m_helper.ShowsRouteButton;}set{m_helper.ShowsRouteButton = value;}}
		public System.Boolean ShowsVolumeSlider {get{return m_helper.ShowsVolumeSlider;}set{m_helper.ShowsVolumeSlider = value;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  System.Drawing.SizeF SizeThatFits (System.Drawing.SizeF f) {return  m_helper.SizeThatFits(f);}
		#endregion
	}
	
	public  partial class UIActivityIndicatorView : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void StartAnimating () { m_helper.StartAnimating();}
		public  void StopAnimating () { m_helper.StopAnimating();}
		#endregion
	}
	
	public  partial class UIBezierPath : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void MoveTo (System.Drawing.PointF point) { m_helper.MoveTo(point);}
		public  void AddLineTo (System.Drawing.PointF point) { m_helper.AddLineTo(point);}
		public  void AddCurveToPoint (System.Drawing.PointF endPoint , System.Drawing.PointF controlPoint1 , System.Drawing.PointF controlPoint2) { m_helper.AddCurveToPoint(endPoint , controlPoint1 , controlPoint2);}
		public  void AddQuadCurveToPoint (System.Drawing.PointF endPoint , System.Drawing.PointF controlPoint) { m_helper.AddQuadCurveToPoint(endPoint , controlPoint);}
		public  void ClosePath () { m_helper.ClosePath();}
		public  void RemoveAllPoints () { m_helper.RemoveAllPoints();}
		public  void AppendPath (MonoTouch.UIKit.UIBezierPath path) { m_helper.AppendPath(path);}
		public  void ApplyTransform (MonoTouch.CoreGraphics.CGAffineTransform transform) { m_helper.ApplyTransform(transform);}
		public  System.Boolean ContainsPoint (System.Drawing.PointF point) {return  m_helper.ContainsPoint(point);}
		public  void Fill () { m_helper.Fill();}
		public  void Stroke () { m_helper.Stroke();}
		public  void Fill (MonoTouch.CoreGraphics.CGBlendMode blendMode , System.Single alpha) { m_helper.Fill(blendMode , alpha);}
		public  void Stroke (MonoTouch.CoreGraphics.CGBlendMode blendMode , System.Single alpha) { m_helper.Stroke(blendMode , alpha);}
		public  void AddClip () { m_helper.AddClip();}
		public  void AddArc (System.Drawing.PointF center , System.Single radius , System.Single startAngle , System.Single endAngle , System.Boolean clockWise) { m_helper.AddArc(center , radius , startAngle , endAngle , clockWise);}
		#endregion
	}
	
	public  partial class UIButton : FrameworkElement
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
			m_helper = MonoTouch.UIKit.UIButton.FromType(MonoTouch.UIKit.UIButtonType.RoundedRect);
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetTitle (System.String title , MonoTouch.UIKit.UIControlState forState) { m_helper.SetTitle(title , forState);}
		public  void SetTitleColor (MonoTouch.UIKit.UIColor color , MonoTouch.UIKit.UIControlState forState) { m_helper.SetTitleColor(color , forState);}
		public  void SetTitleShadowColor (MonoTouch.UIKit.UIColor color , MonoTouch.UIKit.UIControlState forState) { m_helper.SetTitleShadowColor(color , forState);}
		public  void SetImage (MonoTouch.UIKit.UIImage image , MonoTouch.UIKit.UIControlState forState) { m_helper.SetImage(image , forState);}
		public  void SetBackgroundImage (MonoTouch.UIKit.UIImage image , MonoTouch.UIKit.UIControlState forState) { m_helper.SetBackgroundImage(image , forState);}
		public  System.String Title (MonoTouch.UIKit.UIControlState state) {return  m_helper.Title(state);}
		public  MonoTouch.UIKit.UIColor TitleColor (MonoTouch.UIKit.UIControlState state) {return  m_helper.TitleColor(state);}
		public  MonoTouch.UIKit.UIColor TitleShadowColor (MonoTouch.UIKit.UIControlState state) {return  m_helper.TitleShadowColor(state);}
		public  MonoTouch.UIKit.UIImage ImageForState (MonoTouch.UIKit.UIControlState state) {return  m_helper.ImageForState(state);}
		public  MonoTouch.UIKit.UIImage BackgroundImageForState (MonoTouch.UIKit.UIControlState state) {return  m_helper.BackgroundImageForState(state);}
		public  System.Drawing.RectangleF BackgroundRectForBounds (System.Drawing.RectangleF rect) {return  m_helper.BackgroundRectForBounds(rect);}
		public  System.Drawing.RectangleF ContentRectForBounds (System.Drawing.RectangleF rect) {return  m_helper.ContentRectForBounds(rect);}
		public  System.Drawing.RectangleF TitleRectForContentRect (System.Drawing.RectangleF rect) {return  m_helper.TitleRectForContentRect(rect);}
		public  System.Drawing.RectangleF ImageRectForContentRect (System.Drawing.RectangleF rect) {return  m_helper.ImageRectForContentRect(rect);}
		#endregion
	}
	
	public  partial class UILabel : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  System.Drawing.RectangleF TextRectForBounds (System.Drawing.RectangleF bounds , System.Int32 numberOfLines) {return  m_helper.TextRectForBounds(bounds , numberOfLines);}
		public  void DrawText (System.Drawing.RectangleF rect) { m_helper.DrawText(rect);}
		#endregion
	}
	
	public  partial class UIImageView : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void StartAnimating () { m_helper.StartAnimating();}
		public  void StopAnimating () { m_helper.StopAnimating();}
		#endregion
	}
	
	public  partial class UIDatePicker : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetDate (MonoTouch.Foundation.NSDate date , System.Boolean animated) { m_helper.SetDate(date , animated);}
		#endregion
	}
	
	public  partial class UINavigationBar : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void PushNavigationItem (MonoTouch.UIKit.UINavigationItem item , System.Boolean animated) { m_helper.PushNavigationItem(item , animated);}
		public  MonoTouch.UIKit.UINavigationItem PopNavigationItemAnimated (System.Boolean animated) {return  m_helper.PopNavigationItemAnimated(animated);}
		public  void SetItems (MonoTouch.UIKit.UINavigationItem[] items , System.Boolean animated) { m_helper.SetItems(items , animated);}
		#endregion
	}
	
	public  partial class UIPageControl : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void UpdateCurrentPageDisplay () { m_helper.UpdateCurrentPageDisplay();}
		public  System.Drawing.SizeF SizeForNumberOfPages (System.Int32 pageCount) {return  m_helper.SizeForNumberOfPages(pageCount);}
		#endregion
	}
	
	public  partial class UIProgressView : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class UIScrollView : FrameworkElement
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
		#region Events
		public event EventHandler Scrolled;
		public event EventHandler DraggingStarted;
		public event EventHandler DraggingEnded;
		public event EventHandler DecelerationStarted;
		public event EventHandler DecelerationEnded;
		public event EventHandler ScrollAnimationEnded;
		public event EventHandler ScrolledToTop;
		public event EventHandler ZoomingEnded;
		public event EventHandler DidZoom;
		public event EventHandler ZoomingStarted;
		internal override void setupEvents ()
		{
			m_helper.Scrolled+=  delegate (System.Object sender,System.EventArgs e){
			if(Scrolled != null)
			Scrolled(sender,e);
			};
			m_helper.DraggingStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DraggingStarted != null)
			DraggingStarted(sender,e);
			};
			m_helper.DraggingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.DraggingEventArgs e){
			if(DraggingEnded != null)
			DraggingEnded(sender,e);
			};
			m_helper.DecelerationStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationStarted != null)
			DecelerationStarted(sender,e);
			};
			m_helper.DecelerationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(DecelerationEnded != null)
			DecelerationEnded(sender,e);
			};
			m_helper.ScrollAnimationEnded+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrollAnimationEnded != null)
			ScrollAnimationEnded(sender,e);
			};
			m_helper.ScrolledToTop+=  delegate (System.Object sender,System.EventArgs e){
			if(ScrolledToTop != null)
			ScrolledToTop(sender,e);
			};
			m_helper.ZoomingEnded+=  delegate (System.Object sender,MonoTouch.UIKit.ZoomingEndedEventArgs e){
			if(ZoomingEnded != null)
			ZoomingEnded(sender,e);
			};
			m_helper.DidZoom+=  delegate (System.Object sender,System.EventArgs e){
			if(DidZoom != null)
			DidZoom(sender,e);
			};
			m_helper.ZoomingStarted+=  delegate (System.Object sender,MonoTouch.UIKit.UIScrollViewZoomingEventArgs e){
			if(ZoomingStarted != null)
			ZoomingStarted(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetContentOffset (System.Drawing.PointF contentOffset , System.Boolean animated) { m_helper.SetContentOffset(contentOffset , animated);}
		public  void ScrollRectToVisible (System.Drawing.RectangleF rect , System.Boolean animated) { m_helper.ScrollRectToVisible(rect , animated);}
		public  void FlashScrollIndicators () { m_helper.FlashScrollIndicators();}
		public  System.Boolean TouchesShouldBegin (MonoTouch.Foundation.NSSet touches , MonoTouch.UIKit.UIEvent withEvent , MonoTouch.UIKit.UIView inContentView) {return  m_helper.TouchesShouldBegin(touches , withEvent , inContentView);}
		public  System.Boolean TouchesShouldCancelInContentView (MonoTouch.UIKit.UIView view) {return  m_helper.TouchesShouldCancelInContentView(view);}
		public  void SetZoomScale (System.Single scale , System.Boolean animated) { m_helper.SetZoomScale(scale , animated);}
		public  void ZoomToRect (System.Drawing.RectangleF rect , System.Boolean animated) { m_helper.ZoomToRect(rect , animated);}
		#endregion
	}
	
	public  partial class UISearchBar : FrameworkElement
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
		#region Events
		public event EventHandler OnEditingStarted;
		public event EventHandler OnEditingStopped;
		public event EventHandler TextChanged;
		public event EventHandler SearchButtonClicked;
		public event EventHandler BookmarkButtonClicked;
		public event EventHandler CancelButtonClicked;
		public event EventHandler SelectedScopeButtonIndexChanged;
		public event EventHandler ListButtonClicked;
		internal override void setupEvents ()
		{
			m_helper.OnEditingStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(OnEditingStarted != null)
			OnEditingStarted(sender,e);
			};
			m_helper.OnEditingStopped+=  delegate (System.Object sender,System.EventArgs e){
			if(OnEditingStopped != null)
			OnEditingStopped(sender,e);
			};
			m_helper.TextChanged+=  delegate (System.Object sender,MonoTouch.UIKit.UISearchBarTextChangedEventArgs e){
			if(TextChanged != null)
			TextChanged(sender,e);
			};
			m_helper.SearchButtonClicked+=  delegate (System.Object sender,System.EventArgs e){
			if(SearchButtonClicked != null)
			SearchButtonClicked(sender,e);
			};
			m_helper.BookmarkButtonClicked+=  delegate (System.Object sender,System.EventArgs e){
			if(BookmarkButtonClicked != null)
			BookmarkButtonClicked(sender,e);
			};
			m_helper.CancelButtonClicked+=  delegate (System.Object sender,System.EventArgs e){
			if(CancelButtonClicked != null)
			CancelButtonClicked(sender,e);
			};
			m_helper.SelectedScopeButtonIndexChanged+=  delegate (System.Object sender,MonoTouch.UIKit.UISearchBarButtonIndexEventArgs e){
			if(SelectedScopeButtonIndexChanged != null)
			SelectedScopeButtonIndexChanged(sender,e);
			};
			m_helper.ListButtonClicked+=  delegate (System.Object sender,System.EventArgs e){
			if(ListButtonClicked != null)
			ListButtonClicked(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetShowsCancelButton (System.Boolean showsCancelButton , System.Boolean animated) { m_helper.SetShowsCancelButton(showsCancelButton , animated);}
		#endregion
	}
	
	public  partial class UISlider : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetValue (System.Single value , System.Boolean animated) { m_helper.SetValue(value , animated);}
		public  void SetThumbImage (MonoTouch.UIKit.UIImage image , MonoTouch.UIKit.UIControlState forState) { m_helper.SetThumbImage(image , forState);}
		public  void SetMinTrackImage (MonoTouch.UIKit.UIImage image , MonoTouch.UIKit.UIControlState forState) { m_helper.SetMinTrackImage(image , forState);}
		public  void SetMaxTrackImage (MonoTouch.UIKit.UIImage image , MonoTouch.UIKit.UIControlState forState) { m_helper.SetMaxTrackImage(image , forState);}
		public  MonoTouch.UIKit.UIImage ThumbImage (MonoTouch.UIKit.UIControlState forState) {return  m_helper.ThumbImage(forState);}
		public  MonoTouch.UIKit.UIImage MinTrackImage (MonoTouch.UIKit.UIControlState forState) {return  m_helper.MinTrackImage(forState);}
		public  MonoTouch.UIKit.UIImage MaxTrackImage (MonoTouch.UIKit.UIControlState forState) {return  m_helper.MaxTrackImage(forState);}
		public  System.Drawing.RectangleF MinValueImageRectForBounds (System.Drawing.RectangleF forBounds) {return  m_helper.MinValueImageRectForBounds(forBounds);}
		public  System.Drawing.RectangleF MaxValueImageRectForBounds (System.Drawing.RectangleF forBounds) {return  m_helper.MaxValueImageRectForBounds(forBounds);}
		public  System.Drawing.RectangleF TrackRectForBounds (System.Drawing.RectangleF forBounds) {return  m_helper.TrackRectForBounds(forBounds);}
		public  System.Drawing.RectangleF ThumbRectForBounds (System.Drawing.RectangleF bounds , System.Drawing.RectangleF trackRect , System.Single value) {return  m_helper.ThumbRectForBounds(bounds , trackRect , value);}
		#endregion
	}
	
	public  partial class UISwitch : FrameworkElement
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
		#region Events
		public event EventHandler TouchDown;
		public event EventHandler TouchDownRepeat;
		public event EventHandler TouchDragInside;
		public event EventHandler TouchDragOutside;
		public event EventHandler TouchDragEnter;
		public event EventHandler TouchDragExit;
		public event EventHandler TouchUpInside;
		public event EventHandler TouchUpOutside;
		public event EventHandler TouchCancel;
		public event EventHandler ValueChanged;
		public event EventHandler EditingDidBegin;
		public event EventHandler EditingChanged;
		public event EventHandler EditingDidEnd;
		public event EventHandler EditingDidEndOnExit;
		public event EventHandler AllTouchEvents;
		public event EventHandler AllEditingEvents;
		public event EventHandler AllEvents;
		internal override void setupEvents ()
		{
			m_helper.TouchDown+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDown != null)
			TouchDown(sender,e);
			};
			m_helper.TouchDownRepeat+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDownRepeat != null)
			TouchDownRepeat(sender,e);
			};
			m_helper.TouchDragInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragInside != null)
			TouchDragInside(sender,e);
			};
			m_helper.TouchDragOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragOutside != null)
			TouchDragOutside(sender,e);
			};
			m_helper.TouchDragEnter+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragEnter != null)
			TouchDragEnter(sender,e);
			};
			m_helper.TouchDragExit+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchDragExit != null)
			TouchDragExit(sender,e);
			};
			m_helper.TouchUpInside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpInside != null)
			TouchUpInside(sender,e);
			};
			m_helper.TouchUpOutside+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchUpOutside != null)
			TouchUpOutside(sender,e);
			};
			m_helper.TouchCancel+=  delegate (System.Object sender,System.EventArgs e){
			if(TouchCancel != null)
			TouchCancel(sender,e);
			};
			m_helper.ValueChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(ValueChanged != null)
			ValueChanged(sender,e);
			};
			m_helper.EditingDidBegin+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidBegin != null)
			EditingDidBegin(sender,e);
			};
			m_helper.EditingChanged+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingChanged != null)
			EditingChanged(sender,e);
			};
			m_helper.EditingDidEnd+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEnd != null)
			EditingDidEnd(sender,e);
			};
			m_helper.EditingDidEndOnExit+=  delegate (System.Object sender,System.EventArgs e){
			if(EditingDidEndOnExit != null)
			EditingDidEndOnExit(sender,e);
			};
			m_helper.AllTouchEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllTouchEvents != null)
			AllTouchEvents(sender,e);
			};
			m_helper.AllEditingEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEditingEvents != null)
			AllEditingEvents(sender,e);
			};
			m_helper.AllEvents+=  delegate (System.Object sender,System.EventArgs e){
			if(AllEvents != null)
			AllEvents(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetState (System.Boolean newState , System.Boolean animated) { m_helper.SetState(newState , animated);}
		#endregion
	}
	
	public  partial class UITabBar : FrameworkElement
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
		#region Events
		public event EventHandler ItemSelected;
		public event EventHandler WillBeginCustomizingItems;
		public event EventHandler DidBeginCustomizingItems;
		public event EventHandler WillEndCustomizingItems;
		public event EventHandler DidEndCustomizingItems;
		internal override void setupEvents ()
		{
			m_helper.ItemSelected+=  delegate (System.Object sender,MonoTouch.UIKit.UITabBarItemEventArgs e){
			if(ItemSelected != null)
			ItemSelected(sender,e);
			};
			m_helper.WillBeginCustomizingItems+=  delegate (System.Object sender,MonoTouch.UIKit.UITabBarItemsEventArgs e){
			if(WillBeginCustomizingItems != null)
			WillBeginCustomizingItems(sender,e);
			};
			m_helper.DidBeginCustomizingItems+=  delegate (System.Object sender,MonoTouch.UIKit.UITabBarItemsEventArgs e){
			if(DidBeginCustomizingItems != null)
			DidBeginCustomizingItems(sender,e);
			};
			m_helper.WillEndCustomizingItems+=  delegate (System.Object sender,MonoTouch.UIKit.UITabBarFinalItemsEventArgs e){
			if(WillEndCustomizingItems != null)
			WillEndCustomizingItems(sender,e);
			};
			m_helper.DidEndCustomizingItems+=  delegate (System.Object sender,MonoTouch.UIKit.UITabBarFinalItemsEventArgs e){
			if(DidEndCustomizingItems != null)
			DidEndCustomizingItems(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void SetItems (MonoTouch.UIKit.UITabBarItem[] items , System.Boolean animated) { m_helper.SetItems(items , animated);}
		public  void BeginCustomizingItems (MonoTouch.UIKit.UITabBarItem[] items) { m_helper.BeginCustomizingItems(items);}
		public  System.Boolean EndCustomizingAnimated (System.Boolean animated) {return  m_helper.EndCustomizingAnimated(animated);}
		#endregion
	}
	
	public  partial class UIToolbar : FrameworkElement
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void SetItems (MonoTouch.UIKit.UIBarButtonItem[] items , System.Boolean animated) { m_helper.SetItems(items , animated);}
		#endregion
	}
	
	public  partial class UIWebView : FrameworkElement
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
		#region Events
		public event EventHandler LoadStarted;
		public event EventHandler LoadFinished;
		public event EventHandler LoadError;
		internal override void setupEvents ()
		{
			m_helper.LoadStarted+=  delegate (System.Object sender,System.EventArgs e){
			if(LoadStarted != null)
			LoadStarted(sender,e);
			};
			m_helper.LoadFinished+=  delegate (System.Object sender,System.EventArgs e){
			if(LoadFinished != null)
			LoadFinished(sender,e);
			};
			m_helper.LoadError+=  delegate (System.Object sender,MonoTouch.UIKit.UIWebErrorArgs e){
			if(LoadError != null)
			LoadError(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void LoadRequest (MonoTouch.Foundation.NSUrlRequest r) { m_helper.LoadRequest(r);}
		public  void LoadHtmlString (System.String s , MonoTouch.Foundation.NSUrl baseUrl) { m_helper.LoadHtmlString(s , baseUrl);}
		public  void LoadData (MonoTouch.Foundation.NSData data , System.String mimeType , System.String textEncodingName , MonoTouch.Foundation.NSUrl baseUrl) { m_helper.LoadData(data , mimeType , textEncodingName , baseUrl);}
		public  void Reload () { m_helper.Reload();}
		public  void StopLoading () { m_helper.StopLoading();}
		public  void GoBack () { m_helper.GoBack();}
		public  void GoForward () { m_helper.GoForward();}
		public  System.String EvaluateJavascript (System.String script) {return  m_helper.EvaluateJavascript(script);}
		#endregion
	}
	
	public  partial class MKAnnotationView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKAnnotationView (MKAnnotationView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKAnnotationView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKAnnotationView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public System.String ReuseIdentifier {get{return m_helper.ReuseIdentifier;}}
		public MonoTouch.Foundation.NSObject Annotation {get{return m_helper.Annotation;}set{m_helper.Annotation = value;}}
		public MonoTouch.UIKit.UIImage Image {get{return m_helper.Image;}set{m_helper.Image = value;}}
		public System.Drawing.PointF CenterOffset {get{return m_helper.CenterOffset;}set{m_helper.CenterOffset = value;}}
		public System.Drawing.PointF CalloutOffset {get{return m_helper.CalloutOffset;}set{m_helper.CalloutOffset = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean CanShowCallout {get{return m_helper.CanShowCallout;}set{m_helper.CanShowCallout = value;}}
		public MonoTouch.UIKit.UIView LeftCalloutAccessoryView {get{return m_helper.LeftCalloutAccessoryView;}set{m_helper.LeftCalloutAccessoryView = value;}}
		public MonoTouch.UIKit.UIView RightCalloutAccessoryView {get{return m_helper.RightCalloutAccessoryView;}set{m_helper.RightCalloutAccessoryView = value;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void PrepareForReuse () { m_helper.PrepareForReuse();}
		public  void SetSelected (System.Boolean selected , System.Boolean animated) { m_helper.SetSelected(selected , animated);}
		public  void SetDragState (MonoTouch.MapKit.MKAnnotationViewDragState newDragState , System.Boolean animated) { m_helper.SetDragState(newDragState , animated);}
		#endregion
	}
	
	public  partial class MKCircleView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKCircleView (MKCircleView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKCircleView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKCircleView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.MapKit.MKCircle Circle {get{return m_helper.Circle;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor FillColor {get{return m_helper.FillColor;}set{m_helper.FillColor = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor StrokeColor {get{return m_helper.StrokeColor;}set{m_helper.StrokeColor = value;}}
		public System.Single LineWidth {get{return m_helper.LineWidth;}set{m_helper.LineWidth = value;}}
		public MonoTouch.CoreGraphics.CGLineJoin LineJoin {get{return m_helper.LineJoin;}set{m_helper.LineJoin = value;}}
		public MonoTouch.CoreGraphics.CGLineCap Linecap {get{return m_helper.Linecap;}set{m_helper.Linecap = value;}}
		public System.Single MiterLimit {get{return m_helper.MiterLimit;}set{m_helper.MiterLimit = value;}}
		public System.Single LineDashPhase {get{return m_helper.LineDashPhase;}set{m_helper.LineDashPhase = value;}}
		public MonoTouch.Foundation.NSNumber[] LineDashPattern {get{return m_helper.LineDashPattern;}set{m_helper.LineDashPattern = value;}}
		public MonoTouch.CoreGraphics.CGPath Path {get{return m_helper.Path;}set{m_helper.Path = value;}}
		public MonoTouch.Foundation.NSObject Overlay {get{return m_helper.Overlay;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class MKPinAnnotationView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKPinAnnotationView (MKPinAnnotationView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKPinAnnotationView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKPinAnnotationView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.MapKit.MKPinAnnotationColor PinColor {get{return m_helper.PinColor;}set{m_helper.PinColor = value;}}
		public System.Boolean AnimatesDrop {get{return m_helper.AnimatesDrop;}set{m_helper.AnimatesDrop = value;}}
		public MonoTouch.MapKit.MKAnnotationViewDragState DragState {get{return m_helper.DragState;}set{m_helper.DragState = value;}}
		public System.Boolean Draggable {get{return m_helper.Draggable;}set{m_helper.Draggable = value;}}
		public System.String ReuseIdentifier {get{return m_helper.ReuseIdentifier;}}
		public MonoTouch.Foundation.NSObject Annotation {get{return m_helper.Annotation;}set{m_helper.Annotation = value;}}
		public MonoTouch.UIKit.UIImage Image {get{return m_helper.Image;}set{m_helper.Image = value;}}
		public System.Drawing.PointF CenterOffset {get{return m_helper.CenterOffset;}set{m_helper.CenterOffset = value;}}
		public System.Drawing.PointF CalloutOffset {get{return m_helper.CalloutOffset;}set{m_helper.CalloutOffset = value;}}
		public System.Boolean Enabled {get{return m_helper.Enabled;}set{m_helper.Enabled = value;}}
		public System.Boolean Highlighted {get{return m_helper.Highlighted;}set{m_helper.Highlighted = value;}}
		public System.Boolean Selected {get{return m_helper.Selected;}set{m_helper.Selected = value;}}
		public System.Boolean CanShowCallout {get{return m_helper.CanShowCallout;}set{m_helper.CanShowCallout = value;}}
		public MonoTouch.UIKit.UIView LeftCalloutAccessoryView {get{return m_helper.LeftCalloutAccessoryView;}set{m_helper.LeftCalloutAccessoryView = value;}}
		public MonoTouch.UIKit.UIView RightCalloutAccessoryView {get{return m_helper.RightCalloutAccessoryView;}set{m_helper.RightCalloutAccessoryView = value;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class MKOverlayPathView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKOverlayPathView (MKOverlayPathView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKOverlayPathView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKOverlayPathView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor FillColor {get{return m_helper.FillColor;}set{m_helper.FillColor = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor StrokeColor {get{return m_helper.StrokeColor;}set{m_helper.StrokeColor = value;}}
		public System.Single LineWidth {get{return m_helper.LineWidth;}set{m_helper.LineWidth = value;}}
		public MonoTouch.CoreGraphics.CGLineJoin LineJoin {get{return m_helper.LineJoin;}set{m_helper.LineJoin = value;}}
		public MonoTouch.CoreGraphics.CGLineCap Linecap {get{return m_helper.Linecap;}set{m_helper.Linecap = value;}}
		public System.Single MiterLimit {get{return m_helper.MiterLimit;}set{m_helper.MiterLimit = value;}}
		public System.Single LineDashPhase {get{return m_helper.LineDashPhase;}set{m_helper.LineDashPhase = value;}}
		public MonoTouch.Foundation.NSNumber[] LineDashPattern {get{return m_helper.LineDashPattern;}set{m_helper.LineDashPattern = value;}}
		public MonoTouch.CoreGraphics.CGPath Path {get{return m_helper.Path;}set{m_helper.Path = value;}}
		public MonoTouch.Foundation.NSObject Overlay {get{return m_helper.Overlay;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		public  void CreatePath () { m_helper.CreatePath();}
		public  void InvalidatePath () { m_helper.InvalidatePath();}
		public  void ApplyStrokeProperties (MonoTouch.CoreGraphics.CGContext context , System.Single zoomScale) { m_helper.ApplyStrokeProperties(context , zoomScale);}
		public  void ApplyFillProperties (MonoTouch.CoreGraphics.CGContext context , System.Single zoomScale) { m_helper.ApplyFillProperties(context , zoomScale);}
		public  void StrokePath (MonoTouch.CoreGraphics.CGPath path , MonoTouch.CoreGraphics.CGContext context) { m_helper.StrokePath(path , context);}
		public  void FillPath (MonoTouch.CoreGraphics.CGPath path , MonoTouch.CoreGraphics.CGContext context) { m_helper.FillPath(path , context);}
		#endregion
	}
	
	public  partial class MKPolygonView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKPolygonView (MKPolygonView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKPolygonView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKPolygonView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.MapKit.MKPolygon Polygon {get{return m_helper.Polygon;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor FillColor {get{return m_helper.FillColor;}set{m_helper.FillColor = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor StrokeColor {get{return m_helper.StrokeColor;}set{m_helper.StrokeColor = value;}}
		public System.Single LineWidth {get{return m_helper.LineWidth;}set{m_helper.LineWidth = value;}}
		public MonoTouch.CoreGraphics.CGLineJoin LineJoin {get{return m_helper.LineJoin;}set{m_helper.LineJoin = value;}}
		public MonoTouch.CoreGraphics.CGLineCap Linecap {get{return m_helper.Linecap;}set{m_helper.Linecap = value;}}
		public System.Single MiterLimit {get{return m_helper.MiterLimit;}set{m_helper.MiterLimit = value;}}
		public System.Single LineDashPhase {get{return m_helper.LineDashPhase;}set{m_helper.LineDashPhase = value;}}
		public MonoTouch.Foundation.NSNumber[] LineDashPattern {get{return m_helper.LineDashPattern;}set{m_helper.LineDashPattern = value;}}
		public MonoTouch.CoreGraphics.CGPath Path {get{return m_helper.Path;}set{m_helper.Path = value;}}
		public MonoTouch.Foundation.NSObject Overlay {get{return m_helper.Overlay;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class MKPolylineView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.MapKit.MKPolylineView (MKPolylineView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.MapKit.MKPolylineView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.MapKit.MKPolylineView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.MapKit.MKPolyline Polyline {get{return m_helper.Polyline;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor FillColor {get{return m_helper.FillColor;}set{m_helper.FillColor = value;}}
		[TypeConverter(typeof(UIColorConverter))]
		public MonoTouch.UIKit.UIColor StrokeColor {get{return m_helper.StrokeColor;}set{m_helper.StrokeColor = value;}}
		public System.Single LineWidth {get{return m_helper.LineWidth;}set{m_helper.LineWidth = value;}}
		public MonoTouch.CoreGraphics.CGLineJoin LineJoin {get{return m_helper.LineJoin;}set{m_helper.LineJoin = value;}}
		public MonoTouch.CoreGraphics.CGLineCap Linecap {get{return m_helper.Linecap;}set{m_helper.Linecap = value;}}
		public System.Single MiterLimit {get{return m_helper.MiterLimit;}set{m_helper.MiterLimit = value;}}
		public System.Single LineDashPhase {get{return m_helper.LineDashPhase;}set{m_helper.LineDashPhase = value;}}
		public MonoTouch.Foundation.NSNumber[] LineDashPattern {get{return m_helper.LineDashPattern;}set{m_helper.LineDashPattern = value;}}
		public MonoTouch.CoreGraphics.CGPath Path {get{return m_helper.Path;}set{m_helper.Path = value;}}
		public MonoTouch.Foundation.NSObject Overlay {get{return m_helper.Overlay;}}
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
		#region Events
		internal override void setupEvents ()
		{
		}
		
		#endregion
		#region Methods
		#endregion
	}
	
	public  partial class ADBannerView : FrameworkElement
	{
		internal override void ArrangeInternal (Rect finalRect)
		{
			this.Frame = finalRect;
		}
		
		public static implicit operator MonoTouch.iAd.ADBannerView (ADBannerView element)
		{
			return element.m_helper;
		}
		
		internal new MonoTouch.iAd.ADBannerView m_helper;
		protected override void CreateHandle ()
		{
			m_helper = new MonoTouch.iAd.ADBannerView();
			m_view = m_helper;
		}
		
		#region Fields
		#endregion
		#region Properties
		public System.IntPtr ClassHandle {get{return m_helper.ClassHandle;}}
		public MonoTouch.Foundation.NSObject WeakDelegate {get{return m_helper.WeakDelegate;}set{m_helper.WeakDelegate = value;}}
		public MonoTouch.iAd.ADBannerViewDelegate Delegate {get{return m_helper.Delegate;}set{m_helper.Delegate = value;}}
		public System.Boolean BannerLoaded {get{return m_helper.BannerLoaded;}}
		public System.String AdvertisingSection {get{return m_helper.AdvertisingSection;}set{m_helper.AdvertisingSection = value;}}
		public System.Boolean BannerViewActionInProgress {get{return m_helper.BannerViewActionInProgress;}}
		public MonoTouch.Foundation.NSSet RequiredContentSizeIdentifiers {get{return m_helper.RequiredContentSizeIdentifiers;}set{m_helper.RequiredContentSizeIdentifiers = value;}}
		public System.String CurrentContentSizeIdentifier {get{return m_helper.CurrentContentSizeIdentifier;}set{m_helper.CurrentContentSizeIdentifier = value;}}
		public MonoTouch.iAd.AdAction ActionShouldBegin {get{return m_helper.ActionShouldBegin;}set{m_helper.ActionShouldBegin = value;}}
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
		#region Events
		public event EventHandler AdLoaded;
		public event EventHandler FailedToReceiveAd;
		public event EventHandler ActionFinished;
		internal override void setupEvents ()
		{
			m_helper.AdLoaded+=  delegate (System.Object sender,System.EventArgs e){
			if(AdLoaded != null)
			AdLoaded(sender,e);
			};
			m_helper.FailedToReceiveAd+=  delegate (System.Object sender,MonoTouch.iAd.AdErrorEventArgs e){
			if(FailedToReceiveAd != null)
			FailedToReceiveAd(sender,e);
			};
			m_helper.ActionFinished+=  delegate (System.Object sender,System.EventArgs e){
			if(ActionFinished != null)
			ActionFinished(sender,e);
			};
		}
		
		#endregion
		#region Methods
		public  void CancelBannerViewAction () { m_helper.CancelBannerViewAction();}
		#endregion
	}
	
}

