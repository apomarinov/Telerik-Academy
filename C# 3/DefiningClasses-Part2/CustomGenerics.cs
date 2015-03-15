using System;
using System.Text;
using System.Collections.Generic;


namespace CustomGenerics
{	
	public class GenericList<T> where T: IComparable, new()
	{
		private T[] items;
		private int count;
		private int capacity;
		
		private enum CompareItemsResult
		{
			Less = -1,
			Equal,
			Greater
		}
		;
		
		private readonly int defaultCapacity = 2;
		
		public int Count { 
			get { return this.count; } 
		}
		
		public int Capacity {
			get { return this.capacity; }
			set {
				if (value <= 0) {
					throw new ArgumentException ("Invalid Capacity!");
				}
				this.capacity = value;
			}
		}
		
		public GenericList (int capacity)
		{
			this.Capacity = capacity;
			this.count = 0;
			this.items = new T[this.capacity];
		}
		
		public void Add (T item)
		{
			if (this.count == this.capacity) {
				this.AutoGrow ();
			}
			
			this.items [this.count] = item;
			this.count++;
		}
		
		private void AutoGrow ()
		{
			T[] oldItems = this.items;
			this.capacity *= 2;
			this.items = new T[this.capacity];
			Array.Copy (oldItems, this.items, this.count);
		}
		
		public T ItemAt (int index)
		{
			this.ValidateIndex (index);
			return this.items [index];
		}
		
		public void RemoveAt (int index)
		{	
			this.ValidateIndex (index);
			
			T[] newItems = new T[this.capacity];
			for (int i = 0; i < this.count; i++) {
				if (i != index) {
					newItems [i] = this.items [i];
				}	
			}
			this.count--;
		}
		
		public void InsertAt (int index, T item)
		{
			if (index >= 0 && this.count == this.capacity) {
				this.AutoGrow ();
			}
			this.ValidateIndex (index);
			
			T[] itemsBeforeIndex = new T[index];
			for (int i = 0; i < index; i++) {
				itemsBeforeIndex [i] = this.items [i];
			}
			
			T[] itemsAfterIndex = new T[this.count - index];
			for (int i = 0, j = index; j < this.count; i++, j++) {
				itemsAfterIndex [i] = this.items [j];
			}

			T[] newItems = new T[this.capacity];
			newItems [index] = item;			
			
			Array.Copy (itemsBeforeIndex, newItems, itemsBeforeIndex.Length);			
			Array.Copy (itemsAfterIndex, 0, newItems, index + 1, itemsAfterIndex.Length);
			
			this.count++;
			this.items = newItems;
		}
		
		public int IndexOf (T item)
		{
			for (int i = 0; i < this.count; i++) {
				if (this.items [i].CompareTo (item) == (int)CompareItemsResult.Equal) {
					return i;
				}
			}
			return -1;
		}
		
		private void ValidateIndex (int index)
		{
			if (index < 0 || index >= this.count) {
				throw new IndexOutOfRangeException ("Provided index is out of range!");
			}
		}
		
		public T Min ()
		{
			return this.GetItemByCompareResult (CompareItemsResult.Greater);
		}
		
		public T Max ()
		{
			return this.GetItemByCompareResult (CompareItemsResult.Less);
		}
		
		private T GetItemByCompareResult (CompareItemsResult res)
		{
			if (this.count == 0) {
				return new T ();
			}
			T foundItem = this.items [0];
			
			for (int i = 0; i < this.count - 1; i++) {
				if (this.items [i].CompareTo (this.items [i + 1]) == (int)res) {
					foundItem = this.items [i + 1];
				}
			}
			return foundItem;			
		}
		
		public void Clear ()
		{
			this.count = 0;
			this.capacity = this.defaultCapacity;
			this.items = new T[this.defaultCapacity];
		}
		
		public override string ToString ()
		{
			string[] itemStrings = new string[this.count];
			for (int i = 0; i < this.count; i++) {
				itemStrings [i] = this.items [i].ToString ();
			}
			
			return "(" + string.Join (", ", itemStrings) + ")";
		}
	}
	
	public class Matrix<T> where T: struct, IComparable
	{
		private int rows;
		private int columns;
		private T[,] m;
		
		public int Rows { get { return this.rows; } }
		public int Columns { get { return this.columns; } }
		
		public T this [int row, int column] {
			get {
				this.ValidateRowAndColumn (row, column);
				return this.m [row, column];
			}
			set {
				this.ValidateRowAndColumn (row, column);
				this.m [row, column] = value;
			}
		}
		
		public Matrix (int rows, int columns)
		{
			if (rows <= 0 || columns <= 0) {
				throw new ArgumentException ("Rows and columns must be positive.");
			}
			this.rows = rows;
			this.columns = columns;
			this.m = new T[rows, columns];
		}
		
		private void ValidateRowAndColumn (int row, int column)
		{
			if (row < 0 || row >= this.rows || column < 0 || column >= this.columns) {
				throw new IndexOutOfRangeException ("Index is out of range");
			}			
		}
		
		public static Matrix<T> operator * (Matrix<T> m1, Matrix<T> m2)
		{
			if (!m1.IsCompatibleWith (m2)) {
				throw new ArgumentException ("Matrices are not compatible.");
			}
			Matrix<T> newMatrix = new Matrix<T> (m1.rows, m2.columns);
			T result = (dynamic)0;
			for (int i = 0; i < m1.rows; i++) {
				for (int j = 0; j < m2.columns; j++) {
					for (int k = 0; k < m1.columns; k++) {
						result += (dynamic)m1 [i, k] * m2 [k, j];
					}
					newMatrix [i, j] = result;
					result = (dynamic)0;
				}
			}
			return newMatrix;
		}
		
		private bool IsCompatibleWith (Matrix<T> m)
		{
			if (this.columns != m.rows) {
				return false;
			}
			return true;
		}
		
		public override string ToString ()
		{
			StringBuilder matrixString = new StringBuilder ();
			
			for (int i = 0; i < this.rows; i++) {
				matrixString.Append ("{");
				for (int j = 0; j < this.columns; j++) {
					matrixString.Append (this.m [i, j] + " ");
				}
				matrixString.AppendLine ("}");
			}
			
			return matrixString.ToString ();
		}
	}
}









