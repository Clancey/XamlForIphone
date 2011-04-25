using System;
using System.Collections.Generic;
namespace XamlForIphone
{
	public static class Utils
	{
		public static double[] DoubleArrayFromString (string s, int max)
		{
			string[] strings = s.Split(char.Parse(","));
			List<double> doubles = new List<double>(max > 0 ? max : 16);
			int end = max > 0 ? max : int.MaxValue;
			try{
				foreach(var str in strings)
				{
					double coord = double.Parse(str);
					doubles.Add(coord);					
				}
			}
			finally{
				while(doubles.Count  < max)
					doubles.Add(0.0);
			}
		
			return doubles.ToArray();
		}
		
		
	}
}

