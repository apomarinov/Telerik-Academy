using System;
using System.Text;
using System.Collections.Generic;

namespace Calls
{
	public class Call
	{
		public DateTime Date;
		private string phoneNumber;
		private double duration;
		
		public string PhoneNumber {
			get { return phoneNumber; }
			set {
				if (String.IsNullOrEmpty (value) || value.Length < 3)
					throw new ArgumentException ("Invalid Phone Number!");
				this.phoneNumber = value;
			}
		}
		
		public double Duration {
			get { return duration; }
			set {
				if (value <= 0) {
					throw new ArgumentException ("Invalid Call Duration!");
				}
				this.duration = value;
			}
		}
		
		public Call (DateTime date, string phoneNumber, double duration)
		{
			this.Date = date;
			this.PhoneNumber = phoneNumber;
			this.Duration = duration;
		}
	}	
	
	public class CallHistory
	{
		private List<Call> callList;
		
		public CallHistory ()
		{
			this.callList = new List<Call> ();
		}
		
		public void Add (Call call)
		{
			this.callList.Add (call);
		}
		
		public void Remove (Call call)
		{
			this.callList.Remove (call);
		}
		
		public void Clear ()
		{
			this.callList = new List<Call> ();
		}
		
		public double TotalPrice (double pricePerMinute)
		{
			double total = 0;
			for (int i = 0; i < callList.Count; i++) {
				total += callList [i].Duration * pricePerMinute;
			}
			return total;
		}
		
		public override string ToString ()
		{
			StringBuilder output = new StringBuilder ();
			
			for (int i = 0; i < callList.Count; i++) {
				output.AppendFormat ("{0}. Call to: {1}, for {2} minutes, on {3}\n", i + 1, callList [i].PhoneNumber, callList [i].Duration, callList [i].Date);
			}
			
			return output.ToString ();
		}
	}
}