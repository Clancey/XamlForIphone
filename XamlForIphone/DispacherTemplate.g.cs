
using System.Collections.Generic;
//using System.Windows.Threading;
using System.Windows;
using System;
using System.Drawing; 
using System;
using System.ComponentModel; 
using System.Diagnostics; 
using System.Windows.Markup; 
using XamlForIphone;

namespace XamlForIphone
{

public enum SizeType {Fixed,Calculated};
	[ContentProperty("Content")]
	public partial class UIView : MonoTouch.UIKit.UIView , IDependencyObject
	{		
		public UIView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIView source = d as UIView;
			Debug.Assert (source != null, "The source is not an instance of UIView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIActionSheet : MonoTouch.UIKit.UIActionSheet , IDependencyObject
	{		
		public UIActionSheet () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIActionSheet), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIActionSheet source = d as UIActionSheet;
			Debug.Assert (source != null, "The source is not an instance of UIActionSheet!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIAlertView : MonoTouch.UIKit.UIAlertView , IDependencyObject
	{		
		public UIAlertView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIAlertView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIAlertView source = d as UIAlertView;
			Debug.Assert (source != null, "The source is not an instance of UIAlertView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIControl : MonoTouch.UIKit.UIControl , IDependencyObject
	{		
		public UIControl () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIControl), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIControl source = d as UIControl;
			Debug.Assert (source != null, "The source is not an instance of UIControl!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIPickerView : MonoTouch.UIKit.UIPickerView , IDependencyObject
	{		
		public UIPickerView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIPickerView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIPickerView source = d as UIPickerView;
			Debug.Assert (source != null, "The source is not an instance of UIPickerView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UISegmentedControl : MonoTouch.UIKit.UISegmentedControl , IDependencyObject
	{		
		public UISegmentedControl () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UISegmentedControl), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UISegmentedControl source = d as UISegmentedControl;
			Debug.Assert (source != null, "The source is not an instance of UISegmentedControl!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UITableView : MonoTouch.UIKit.UITableView , IDependencyObject
	{		
		public UITableView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UITableView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UITableView source = d as UITableView;
			Debug.Assert (source != null, "The source is not an instance of UITableView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UITableViewCell : MonoTouch.UIKit.UITableViewCell , IDependencyObject
	{		
		public UITableViewCell () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UITableViewCell), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UITableViewCell source = d as UITableViewCell;
			Debug.Assert (source != null, "The source is not an instance of UITableViewCell!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UITextField : MonoTouch.UIKit.UITextField , IDependencyObject
	{		
		public UITextField () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UITextField), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UITextField source = d as UITextField;
			Debug.Assert (source != null, "The source is not an instance of UITextField!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UITextView : MonoTouch.UIKit.UITextView , IDependencyObject
	{		
		public UITextView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UITextView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UITextView source = d as UITextView;
			Debug.Assert (source != null, "The source is not an instance of UITextView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIWindow : MonoTouch.UIKit.UIWindow , IDependencyObject
	{		
		public UIWindow () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIWindow), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIWindow source = d as UIWindow;
			Debug.Assert (source != null, "The source is not an instance of UIWindow!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIActivityIndicatorView : MonoTouch.UIKit.UIActivityIndicatorView , IDependencyObject
	{		
		public UIActivityIndicatorView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIActivityIndicatorView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIActivityIndicatorView source = d as UIActivityIndicatorView;
			Debug.Assert (source != null, "The source is not an instance of UIActivityIndicatorView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIBezierPath : MonoTouch.UIKit.UIBezierPath , IDependencyObject
	{		
		public UIBezierPath () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIBezierPath), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIBezierPath source = d as UIBezierPath;
			Debug.Assert (source != null, "The source is not an instance of UIBezierPath!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIButton : MonoTouch.UIKit.UIButton , IDependencyObject
	{		
		public UIButton () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIButton), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIButton source = d as UIButton;
			Debug.Assert (source != null, "The source is not an instance of UIButton!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UILabel : MonoTouch.UIKit.UILabel , IDependencyObject
	{		
		public UILabel () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UILabel), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UILabel source = d as UILabel;
			Debug.Assert (source != null, "The source is not an instance of UILabel!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIImageView : MonoTouch.UIKit.UIImageView , IDependencyObject
	{		
		public UIImageView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIImageView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIImageView source = d as UIImageView;
			Debug.Assert (source != null, "The source is not an instance of UIImageView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIDatePicker : MonoTouch.UIKit.UIDatePicker , IDependencyObject
	{		
		public UIDatePicker () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIDatePicker), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIDatePicker source = d as UIDatePicker;
			Debug.Assert (source != null, "The source is not an instance of UIDatePicker!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UINavigationBar : MonoTouch.UIKit.UINavigationBar , IDependencyObject
	{		
		public UINavigationBar () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UINavigationBar), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UINavigationBar source = d as UINavigationBar;
			Debug.Assert (source != null, "The source is not an instance of UINavigationBar!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIPageControl : MonoTouch.UIKit.UIPageControl , IDependencyObject
	{		
		public UIPageControl () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIPageControl), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIPageControl source = d as UIPageControl;
			Debug.Assert (source != null, "The source is not an instance of UIPageControl!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIProgressView : MonoTouch.UIKit.UIProgressView , IDependencyObject
	{		
		public UIProgressView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIProgressView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIProgressView source = d as UIProgressView;
			Debug.Assert (source != null, "The source is not an instance of UIProgressView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIScrollView : MonoTouch.UIKit.UIScrollView , IDependencyObject
	{		
		public UIScrollView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIScrollView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIScrollView source = d as UIScrollView;
			Debug.Assert (source != null, "The source is not an instance of UIScrollView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UISearchBar : MonoTouch.UIKit.UISearchBar , IDependencyObject
	{		
		public UISearchBar () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UISearchBar), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UISearchBar source = d as UISearchBar;
			Debug.Assert (source != null, "The source is not an instance of UISearchBar!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UISlider : MonoTouch.UIKit.UISlider , IDependencyObject
	{		
		public UISlider () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UISlider), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UISlider source = d as UISlider;
			Debug.Assert (source != null, "The source is not an instance of UISlider!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UISwitch : MonoTouch.UIKit.UISwitch , IDependencyObject
	{		
		public UISwitch () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UISwitch), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UISwitch source = d as UISwitch;
			Debug.Assert (source != null, "The source is not an instance of UISwitch!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UITabBar : MonoTouch.UIKit.UITabBar , IDependencyObject
	{		
		public UITabBar () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UITabBar), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UITabBar source = d as UITabBar;
			Debug.Assert (source != null, "The source is not an instance of UITabBar!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIToolbar : MonoTouch.UIKit.UIToolbar , IDependencyObject
	{		
		public UIToolbar () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIToolbar), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIToolbar source = d as UIToolbar;
			Debug.Assert (source != null, "The source is not an instance of UIToolbar!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
	[ContentProperty("Content")]
	public partial class UIWebView : MonoTouch.UIKit.UIWebView , IDependencyObject
	{		
		public UIWebView () : base ()
		{
		
		}
	
		private static Dictionary<Type,Dictionary<string,DependencyProperty>> propertyDeclarations = new Dictionary<Type,Dictionary<string,DependencyProperty>>();
		private Dictionary<DependencyProperty,object> properties = new Dictionary<DependencyProperty,object>();

		[MonoTODO]
		public bool IsSealed {
			get { return false; }
		}

		public DependencyObjectType DependencyObjectType { 
			get { return DependencyObjectType.FromSystemType (GetType()); }
		}

		public void ClearValue(DependencyProperty dp)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			properties[dp] = null;
		}
		
		public void ClearValue(DependencyPropertyKey key)
		{
			ClearValue (key.DependencyProperty);
		}

		public void CoerceValue (DependencyProperty dp)
		{
			PropertyMetadata pm = dp.GetMetadata (this);
			if (pm.CoerceValueCallback != null)
				pm.CoerceValueCallback (this, GetValue (dp));
		}

		public sealed override bool Equals (object obj)
		{
			throw new NotImplementedException("Equals");
		}

		public sealed override int GetHashCode ()
		{
			throw new NotImplementedException("GetHashCode");
		}

		[MonoTODO]
		public LocalValueEnumerator GetLocalValueEnumerator()
		{
			return new LocalValueEnumerator(properties);
		}
		
		public object GetValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? dp.DefaultMetadata.DefaultValue : val;
		}
		
		[MonoTODO]
		public void InvalidateProperty(DependencyProperty dp)
		{
			throw new NotImplementedException("InvalidateProperty(DependencyProperty dp)");
		}
		
		public void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			PropertyMetadata pm = e.Property.GetMetadata (e.Property.OwnerType);
			if (pm.PropertyChangedCallback != null)
				pm.PropertyChangedCallback (this, e);
		}
		
		public object ReadLocalValue(DependencyProperty dp)
		{
			object val = properties[dp];
			return val == null ? DependencyProperty.UnsetValue : val;
		}
		
		public void SetValue(DependencyProperty dp, object value)
		{
			if (IsSealed)
				throw new InvalidOperationException ("Cannot manipulate property values on a sealed DependencyObject");

			if (!dp.IsValidType (value))
				throw new ArgumentException ("value not of the correct type for this DependencyProperty");

			ValidateValueCallback validate = dp.ValidateValueCallback;
			if (validate != null && !validate(value))
				throw new Exception("Value does not validate");
			
			object oldValue = null;
			if(properties.ContainsKey(dp))
				oldValue = 	properties[dp];
			properties[dp] = value;
			//if(oldValue != null)
			OnPropertyChanged(new DependencyPropertyChangedEventArgs(dp,oldValue,value));
		}
		
		public void SetValue(DependencyPropertyKey key, object value)
		{
			SetValue (key.DependencyProperty, value);
		}

		public bool ShouldSerializeProperty (DependencyProperty dp)
		{
			throw new NotImplementedException ();
		}

		internal static void register(Type t, DependencyProperty dp)
		{
			DependencyObject.register(t,dp);
		}
		
#region Content
		/// <summary> 
		/// Gets or sets the content of a ContentControl.
		/// </summary>
		public object Content {
			get { return GetValue (ContentProperty); }
			set { SetValue (ContentProperty, value); }
		}

		/// <summary> 
		/// Identifies the Content dependency property.
		/// </summary>
		public static readonly DependencyProperty ContentProperty = DependencyProperty.Register ("Content", typeof(object), typeof(UIWebView), new PropertyMetadata (OnContentPropertyChanged));

		private static void OnContentPropertyChanged (IDependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			UIWebView source = d as UIWebView;
			Debug.Assert (source != null, "The source is not an instance of UIWebView!");
			
			// Notify derived classes of the change 
			source.OnContentChanged (e.OldValue, e.NewValue);
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
		protected virtual void OnContentChanged (object oldContent, object newContent)
		{
			if (this is MonoTouch.UIKit.UIView) {
				if (oldContent is MonoTouch.UIKit.UIView)
					(oldContent as MonoTouch.UIKit.UIView).RemoveFromSuperview ();
				if (newContent is MonoTouch.UIKit.UIView)
					this.AddSubview ((newContent as MonoTouch.UIKit.UIView));
			}
		}
		
		
#region Sizes
		public string Width {
			
			get	{return Frame.Width.ToString();}
			set {
				var width = int.Parse(value);
				var frame = Frame;
				frame.Width = width;
				Frame = frame;			
			}
		}
		
		
		public string Height {
			
			get	{return Frame.Height.ToString();}
			set { 
				var height = int.Parse(value);
				var frame = Frame;
				frame.Height = height;
				Frame = frame;
			}
		}
		
		#endregion Sizes
		
		
		
	}
	
	
}


