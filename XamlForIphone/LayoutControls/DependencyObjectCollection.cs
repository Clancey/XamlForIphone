//
// DependencyObjectCollection.cs:
//
// Contact:
//   Moonlight List (moonlight-list@lists.ximian.com)
//
// Copyright 2010 Novell, Inc.
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


using Mono;
using System;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace System.Windows {
	public partial class DependencyObjectCollection<T> : DependencyObject, IList<T>, IList, INotifyCollectionChanged {
		List<T> Items = new List<T> ();

		public event NotifyCollectionChangedEventHandler CollectionChanged;

		public int Count {
			get { return Items.Count; }
		}

		bool InHandler {
			get; set;
		}

		public bool IsReadOnly {
			get { return false; }
		}

		int IList.Add (object value)
		{
			Add ((T) value);
			return Count;
		}

		void IList.Remove (object value)
		{
			Remove ((T) value);
		}

		void IList.Insert (int index, object item)
		{
			Insert (index, (T) item);
		}

		object IList.this [int index] {
			get { return this[index]; }
			set { this[index] = (T)value; }
		}

		bool IList.Contains (object value)
		{
			return ((IList) this).IndexOf (value) != -1;
		}

		int IList.IndexOf (object value)
		{
			return IndexOf ((T) value);
		}

		void ICollection.CopyTo (Array array, int index)
		{
			foreach (var v in this)
				array.SetValue (v, index ++);
		}

		object ICollection.SyncRoot {
			get { return this; }
		}

		bool ICollection.IsSynchronized {
			get { return false; }
		}
		
		bool System.Collections.IList.IsFixedSize {
			get { return false; }
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		public void Clear ()
		{
			ThrowIfInHandler ();
			try {
				InHandler = true;

				//Mono.NativeMethods.collection_clear (native);
				Items.Clear();
				CollectionChanged.Invoke (this,new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Reset));
			} finally {
				InHandler = false;
			}
		}


		void Initialize ()
		{
		}

		public void RemoveAt (int index)
		{
			ThrowIfInHandler ();
			try {
				InHandler = true;

				var oldItem = this [index];
				Items.Remove(oldItem);
				CollectionChanged.Invoke (this,new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Remove, oldItem, index));
			} finally {
				InHandler = false;
			}
		}

		public void Add (T item)
		{
			ThrowIfInHandler ();
			try {
				InHandler = true;
				Items.Add(item);
				CollectionChanged.Invoke (this, new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Add, item, Count - 1));
			} finally {
				InHandler = false;
			}
		}

		public void Insert (int index, T item)
		{
			ThrowIfInHandler ();
			try {
				InHandler = true;
				Items.Insert(index,item);
				CollectionChanged.Invoke (this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
			} finally {
				InHandler = false;
			}
		}

		public bool Remove (T item)
		{
			ThrowIfInHandler ();
			try {
				InHandler = true;

				var oldIndex = IndexOf (item);
				Items.Remove(item);
				CollectionChanged.Invoke (this, new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Remove, item, oldIndex));
				return true;
			} finally {
				InHandler = false;
			}
		}

		public T this [int index] {
			get { return Items[index]; }
			set {
				ThrowIfInHandler ();
				try {
					InHandler = true;
					Items[index] =value;
					//Value v;
					//using ((v = Value.FromObject (value))) {
					//	var oldItem = this [index];
					//	Mono.NativeMethods.collection_set_value_at (native, index, ref v);
					//	CollectionChanged.Raise (this, NotifyCollectionChangedAction.Replace, value, oldItem, index);
				
				} finally {
					InHandler = false;
				}
			}
		}

		public bool Contains (T item)
		{
			return Items.Contains (item);
		}

		public int IndexOf (T item)
		{
			return Items.IndexOf (item);
		}

		public void CopyTo (T [] array, int arrayIndex)
		{
			Items.CopyTo (array, arrayIndex);
		}

		public IEnumerator<T> GetEnumerator ()
		{
			return Items.GetEnumerator ();
		}

		void ThrowIfInHandler ()
		{
			if (InHandler)
				throw new InvalidOperationException ("Cannot modify the collection from a CollectionChanged handler");
		}
	}
}
