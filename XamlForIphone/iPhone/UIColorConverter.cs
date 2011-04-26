using System;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Globalization;
namespace XamlForIphone
{
	public class UIColorConverter : TypeConverter
	{

		public override object ConvertTo (ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{			
			var str = value.ToString();
			return str;
		}
		
		public override bool CanConvertTo (ITypeDescriptorContext context, Type destinationType)
		{
			return true;
		}
		public override object ConvertFrom (ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{	
			var str = value.ToString();
			PropertyInfo[] props = typeof(MonoTouch.UIKit.UIColor).GetProperties ();
			PropertyInfo prop = props.Select (p => p).Where (p => p.Name == str).FirstOrDefault ();
			if (prop != null)
				return (MonoTouch.UIKit.UIColor)prop.GetValue (new MonoTouch.UIKit.UIColor(), null);
			return null;
			
		}
		public override object CreateInstance (ITypeDescriptorContext context, IDictionary propertyValues)
		{
			return base.CreateInstance (context, propertyValues);
		}
		public override bool CanConvertFrom (ITypeDescriptorContext context, Type sourceType)
		{
			return true;
		}
	}
}

