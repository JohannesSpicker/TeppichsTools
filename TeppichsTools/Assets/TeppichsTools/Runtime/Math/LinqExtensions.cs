using System.Collections.Generic;
using System.Linq;

namespace TeppichsTools.Math
{
	public static class LinqExtensions
	{
		public static float  Product(this IEnumerable<float>  source) => source.Aggregate(1f, (acc, val) => acc * val);
		public static int    Product(this IEnumerable<int>    source) => source.Aggregate(1,  (acc, val) => acc * val);
		public static double Product(this IEnumerable<double> source) => source.Aggregate(1d, (acc, val) => acc * val);
		public static long   Product(this IEnumerable<long>   source) => source.Aggregate(1L, (acc, val) => acc * val);

		public static decimal Product(this IEnumerable<decimal> source) =>
			source.Aggregate(decimal.One, (acc, val) => acc * val);
	}
}