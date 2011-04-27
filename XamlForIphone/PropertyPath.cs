//
// PropertyPath.cs
//
// Contact:
//   Moonlight List (moonlight-list@lists.ximian.com)
//
// Copyright 2008 Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;

namespace System.Windows
{
	public sealed class PropertyPath
	{
		private string path;
		private string expanded_path;

		private DependencyProperty property;
		
		public PropertyPath (string path, params object [] pathParameters)
		{
			if (pathParameters == null)
				throw new NullReferenceException ();
			else if (pathParameters.Length > 0)
				throw new ArgumentOutOfRangeException ();
			
			this.path = path;
		}

		internal PropertyPath (string path, string expanded_path)
		{
			this.path = path;
			this.expanded_path = expanded_path;
		}

		public PropertyPath (object parameter)
		{
			property = parameter as DependencyProperty;
			path = parameter as string;
		}
		
		internal IntPtr NativeDP {
			get { return property == null ? IntPtr.Zero : property.Native;  }
		}
		public string Path {
			get { return property == null ? path : "(0)"; }
		}
		internal string ExpandedPath {
			get { return property == null ? expanded_path : "(0)"; }
		}
		internal string ParsePath {
			get {
				if (property != null)
					return "(0)";
				if (expanded_path != null)
					return expanded_path;
				return path;
			}
		}
	}
}
