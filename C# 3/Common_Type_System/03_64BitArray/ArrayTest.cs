using System;
using Array64Bit;
using System.Collections.Generic;


class ArrayTest
{
	public static void Main ()
	{
		string asd = "";
		Validator.ValueConformToDelegate (asd, "blablabla", x => string.IsNullOrEmpty (asd));
	}
}

public static class Validator
{
	public static void ValueConformToDelegate<T> (T value, string errMsg, Func<T, bool> validator)
	{
		if (validator (value)) {
			throw new ArgumentException (errMsg);
		}
	}
}