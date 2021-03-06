using System;
using System.Reflection;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Collections.ObjectModel;
namespace XamlForIphone
{
		enum VisualTreeWalkerDirection {
			Logical,
			LogicalReverse,
			ZForward,
			ZReverse
		};
	public class VisualTreeWalker
	{
		public VisualTreeWalker (UIElement item)
		{
			index = 0;
			collection = null;
			content = item.SubtreeObject;
			this.direction = direction;
			this.ref_content = ref_content;
			if(content == null)
				return;
			
			if(content is IList)
			{
				collection = content as IList;
			}

		}
		object content;
		IList collection;
		int index;
		VisualTreeWalkerDirection direction = VisualTreeWalkerDirection.Logical;
		bool ref_content = true;
		public UIElement Step ()
		{
			UIElement result = null;

			if (collection != null) {
				UIElementCollection uiecollection = null;
				int count = GetCount ();
		
				if (count < 0 || index >= count)
					return null;
				
				if (count == 1 && index == 0) {
					index ++;
					return (UIElement)collection[0];
				}
		
				if (direction == VisualTreeWalkerDirection.ZForward || direction == VisualTreeWalkerDirection.ZReverse) {
					uiecollection = (UIElementCollection)collection;
			
					if (uiecollection.z_sorted.Count != count) {
		#if SANITY
						printf ("VisualTreeWalker: unexpectedly got an unsorted UIElementCollection\n");
		#endif
						uiecollection.ResortByZIndex ();
					}
					
				}
		
				switch (direction) {
					case VisualTreeWalkerDirection.ZForward:
						result = (UIElement)uiecollection.z_sorted[index];
						break;
					case VisualTreeWalkerDirection.ZReverse:
						result = (UIElement)uiecollection.z_sorted[count - (index + 1)];
						break;
					case VisualTreeWalkerDirection.Logical: {
						result = (UIElement)collection[index];
						break;
					}
					case VisualTreeWalkerDirection.LogicalReverse: {
						result = (UIElement)collection[(count - (index + 1))];
						break;
					}
				}
				
				index++;
			} else {
				if (index == 0) {
					index++;
					result = (UIElement)content;
				} else { 
					result = null;
				}
			}
		
			return result;
			
			
			
		}
		public int GetCount ()
		{	
			if (content == null)
				return 0;
		
			if (collection == null)
				return 1;
		
			return collection.Count;
		}
	}
	

}

