using System;
using MonoTouch.UIKit;
namespace XamlForIphone
{
	public partial class UIButton
	{
		public string Text
		{
			get {return m_helper.TitleLabel.Text;}
			set{ m_helper.SetTitle(value,UIControlState.Normal);}
		}
	}
}

