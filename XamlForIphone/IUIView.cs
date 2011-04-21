using System;
using System.Windows;
namespace XamlForIphone
{
	public interface IUIView
	{
		#region Sizes
		string Width {get;set;}
		
		string Height {get;set;}		
		SizeType HeightType {get;set;}
		SizeType WidthType {get;set;}
		HorizontalAlignment HorizontalAlignment{get;set;}
		VerticalAlignment VerticalAlignment{get;set;}
		#endregion Sizes
	}
}

