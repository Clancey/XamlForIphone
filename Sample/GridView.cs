using System;
using MonoTouch.UIKit;
using System.Drawing;
using XamlControls;
namespace Sample
{
	public class GridView : MonoTouch.UIKit.UIView
	{
		public XamlControls.UITextField textInput;
		public XamlControls.UILabel label;
		public XamlControls.UIImageView imageView;
		private XamlControls.UIGrid grid;	
		
		public GridView (RectangleF rect) : base (rect)
		{
			this.BackgroundColor = UIColor.Gray;
			// pass in Number of collumns/rows
			grid = new XamlControls.UIGrid(this.Frame,6,10);
			
			//pass in collumn/row width/height
			//grid = new UIGrid(this.Frame,30f,30f);
			
			textInput = new XamlControls.UITextField(){BackgroundColor = UIColor.White};
			
			label = new XamlControls.UILabel{Text = "label 1"};
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

