using System;
using System.Collections.Specialized;
namespace XamlForIphone
{
	public partial class Canvas : Panel
	{
		#region implemented abstract members of XamlForIphone.Panel
		internal override void HandleChildrenCollectionChanged (object sender, NotifyCollectionChangedEventArgs e)
		{
			switch(e.Action)
			{
			case NotifyCollectionChangedAction.Add:
				foreach(var item in e.NewItems)
				{
					this.AddSubview((MonoTouch.UIKit.UIView)item);
				}
				break;
			case NotifyCollectionChangedAction.Remove:
				foreach(var item in e.NewItems)
				{
					((MonoTouch.UIKit.UIView)item).RemoveFromSuperview();
				}
				break;
			case NotifyCollectionChangedAction.Reset :
				foreach(var view in Subviews)
				{
					view.RemoveFromSuperview();	
				}
				break;
			}
		}
		
		#endregion
		public Canvas ()
		{
			Console.Write(Children);
			
		}
	}
}

