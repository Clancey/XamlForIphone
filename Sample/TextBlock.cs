using System;
using MonoTouch.UIKit;
using System.Drawing;
namespace Microsoft.Phone.Controls
{
	public class TextBlock : UITextView
	{
		public TextBlock () : base (new Rectangle(0,0,100,100))
		{
			//this.BackgroundColor = UIColor.Green;
		}
		public string Name {get;set;}
	}
}

