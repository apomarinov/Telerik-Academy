using System;
using Calls;

namespace GSMModules
{
	public class GSM
	{
		private string manufacturer;
		private string model;
		private string brand;
		private int price;
		private CallHistory callHistory;
		
		public string Owner;
		public GSMBattery Battery;
		public GSMDisplay Display;
		
		public string Manufacturer { 
			get { return this.manufacturer; }
			set {
				if (String.IsNullOrEmpty (value))
					throw new ArgumentException ("Invalid Manufacturer!");
				this.manufacturer = value;
			}
		}
		public string Model { 
			get { return this.model; }
			set {
				if (String.IsNullOrEmpty (value))
					throw new ArgumentException ("Invalid Model!");
				this.model = value;
			}
		}
		public string Brand {
			get { return this.brand; }
			set {
				if (String.IsNullOrEmpty (value))
					throw new ArgumentException ("Invalid Brand!");
				this.brand = value;
			}
		}
		public int Price {
			get { return this.price; }
			set {
				if (value >= 0) {
					this.price = value;
				} else {
					throw new ArgumentException ("Invalid Price!");
				}
			}
		}
		
		public static GSM iPhone4S = new GSM ("Apple", "iPhone", "4S", 300, "Some One",
		                                      new GSMBattery ("KGY78", 200, 12, GSMBatteryType.LiIon),
		                                      new GSMDisplay (640, 960, 16000000));
		
		public GSM (string manufacturer, string brand, string model) :this(manufacturer, brand, model, 0, null, null, null)
		{
			
		}
		
		public GSM (string manufacturer, string brand, string model, int price, string owner, GSMBattery battery, GSMDisplay display)
		{
			this.Manufacturer = manufacturer;
			this.Model = model;
			this.Brand = brand;
			this.Price = price;
			this.Owner = owner ?? String.Empty;
			this.Battery = battery ?? new GSMBattery ();
			this.Display = display ?? new GSMDisplay ();
			this.callHistory = new CallHistory ();
		}
		
		public void AddCall (Call call)
		{
			this.callHistory.Add (call);
		}
		
		public void RemoveCall (Call call)
		{
			this.callHistory.Remove (call);
		}
		
		public void ClearCallHistory ()
		{
			this.callHistory.Clear ();
		}
		
		public string CallHistoryToString ()
		{
			string historyString = this.callHistory.ToString ();
			return historyString.Length == 0 ? "Call history is empty" : historyString;
		}
		
		public double CallsPrice (double pricePerMinute)
		{
			return this.callHistory.TotalPrice (pricePerMinute);
		}
		
		public override string ToString ()
		{
			string format = "Manufacturer: {0}\n" +
				"Brand       : {1}\n" +
				"Model       : {2}\n" +
				"Price       : {3}\n" +
				"Owner       : {4}\n" +
				"Battery:     \n(\n{5})\n" +
				"Display:     \n(\n{6})";
			return String.Format (format, this.manufacturer, this.model, this.brand, this.Price, this.Owner, this.Battery.ToString (), this.Display.ToString ());
		}
	}	
	
	public enum GSMBatteryType
	{
		None = -1,
		LiIon,
		NiCd,
		NiMH
	}
	;
	
	public class GSMBattery
	{
		private string model;
		public int hoursIdle;
		public int hoursTalk;
		public GSMBatteryType type;
		
		
		public string Model {
			get { return model; }
		}
		
		public GSMBattery () : this("", 0, 0, GSMBatteryType.None)
		{
			
		}
		
		public GSMBattery (string model) : this(model, 0, 0, GSMBatteryType.None)
		{
			
		}
		
		public GSMBattery (string model, int hoursIdle, int hoursTalk, GSMBatteryType type)
		{
			this.model = model;
			this.hoursIdle = hoursIdle;
			this.hoursTalk = hoursTalk;
			this.type = type;
		}
		
		public override string ToString ()
		{
			string format = "Model       : {0}\n" +
				"Type        : {1}\n" + 
				"Hours Idle  : {2}\n" +
				"Hours Talk  : {3}\n";
			return String.Format (format, this.model, this.type, this.hoursIdle, this.hoursTalk);
		}
	}	
	
	public class GSMDisplay
	{
		private int sizeX;
		private int sizeY;
		private int colors;
		
		public int SizeX {
			get { return sizeX; }
		}
		public int SizeY {
			get { return sizeY; }
		}
		public int Colors {
			get { return colors; }
		}
		
		public GSMDisplay () :this(0, 0, 0)
		{
			
		}
		
		public GSMDisplay (int sizeX, int sizeY, int colors)
		{
			this.sizeX = sizeX;
			this.sizeY = sizeY;
			this.colors = colors;
		}
		
		public override string ToString ()
		{
			string format = "Width  : {0}\n" +
				"Height : {1}\n" +
				"Colors : {2}\n";
			return String.Format (format, this.sizeX, this.sizeY, this.colors);
		}
	}	
}

