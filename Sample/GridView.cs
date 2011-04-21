using System;
using System.Drawing;
using XamlForIphone;
using MonoTouch.UIKit;
namespace Sample
{
	public class GridView : MonoTouch.UIKit.UIView
	{
		public XamlForIphone.UITextField textInput;
		public XamlForIphone.UILabel label;
		public XamlForIphone.UIImageView imageView;
		private XamlForIphone.UIGrid grid;	
		public GridView () :this (new RectangleF(0,0,100,100))
		{
			
		}
		public GridView (RectangleF rect) : base (rect)
		{
			this.BackgroundColor = UIColor.Gray;
			// pass in Number of collumns/rows
			grid = new UIGrid(this.Frame,6,10);
			
			//pass in collumn/row width/height
			//grid = new UIGrid(this.Frame,30f,30f);
			
			textInput = new XamlForIphone.UITextField(){BackgroundColor = UIColor.White};
			
			label = new XamlForIphone.UILabel{Text = "label 1"};
			//imageView = new XamlControls.UIImageView(null);
			
			this.AddSubview(grid);
			
			UIGrid.SetColumn(textInput,4);
			UIGrid.SetColumnSpan(textInput,3);
			
			UIGrid.SetRow(textInput,1);
			UIGrid.SetRowSpan(textInput,1);
			UIGrid.SetRowSpan(textInput,2);
			
			UIGrid.SetColumn(label,1);
			UIGrid.SetColumnSpan(label,3);			
			UIGrid.SetRow(label,1);
			UIGrid.SetRowSpan(label,1);
			
			//UIGrid.SetColumn(imageView,1);
			//UIGrid.SetColumnSpan(imageView,6);			
			//UIGrid.SetRow(imageView,2);
			//UIGrid.SetRowSpan(imageView,6);
			
			grid.AddSubview(textInput);
			grid.AddSubview(label);
			//grid.AddSubview(imageView);
			
			
		}
		//Override to pass the value to resize the grid as well.
		public override RectangleF Frame {
			get {
				return base.Frame;
			}
			set {
				if(grid != null)
					grid.Frame = value;
				base.Frame = value;
			}
		}
	}
}

