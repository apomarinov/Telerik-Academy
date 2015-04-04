// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array64Bit
{
	public class BitArray64 : IEnumerable<int>
	{
		private ulong number;
		
		public BitArray64 ()
		{
		}
		
		public int this [int pos] {
			get {
				if (pos < 0 || pos > 63) {
					throw new ArgumentOutOfRangeException ("Index is out of range");
				}
				
				return (int)((this.number >> pos) & 1);
			}
			set {
				if (pos < 0 || pos > 63) {
					throw new ArgumentOutOfRangeException ("Index is out of range");
				}
				if (value < 0 || value > 1) {
					throw new ArgumentException ("Value must be 0 or 1");
				}
				if (value == 1) {
					this.number = this.number | ((ulong)1 << pos);
				} else {
					this.number = this.number & (~((ulong)1 << pos));
				}
			}
		}
		
		public override string ToString ()
		{
			var sb = new StringBuilder ();
			
			for (int i = 0, currentBit; i < 64; i++) {
				currentBit = (int)(this.number >> (63 - i)) & 1;
				sb.Append (currentBit);
			}
			
			return sb.ToString ();
		}
		
		public override bool Equals (object obj)
		{
			BitArray64 other = obj as BitArray64;
			
			if (other == null) {
				return false;
			}
			
			return this.number == other.number;
		}
		
		public static bool operator == (BitArray64 first, BitArray64 second)
		{
			return Object.Equals (first, second);
		}
		
		public static bool operator != (BitArray64 first, BitArray64 second)
		{
			return !Object.Equals (first, second);
		}
		
		public override int GetHashCode ()
		{		
			int hash = this [0];
			foreach (byte bit in this) {
				hash = (hash * 17) + bit.GetHashCode ();
			}			
			
			return hash;
		}
		
		public IEnumerator<int> GetEnumerator ()
		{
			for (int i = 0; i < 64; i++) {
				yield return this [i];
			}
		}
		
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
}