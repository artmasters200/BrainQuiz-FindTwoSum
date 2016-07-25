using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTwoSum
{
    class Program
    {
        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = i+1; j < list.Count; j++)
                {
                    //if (i == j)
                    //{
                    //    continue; //should not be identical indices
                    //}

                    var item1 = list[i];
                    var item2 = list[j];
                    if (item1 + item2 == sum)
                    {
                        var result = new Tuple<int, int>(i, j);
                        return result;
                    }
                }
            }

            return null;
        }

	public static Tuple<int,int> FindTwoSum2(List<int> list, int sum)
	{
		int a = 0;
		int z = 0;
			
		foreach(int x in list)
		{
			int y = sum - x;
			int index1 = list.IndexOf(x);
			int index2 = list.IndexOf(y);
			
			
			a = index1;
			z = index2;

		}
		
		return new Tuple<int,int>(a,z);
		
	}

        public static Tuple<int, int> FindTwoSumSlowest(IList<int> list, int sum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (i == j)
                    {
                        continue; //should not be identical indices
                    }

                    var item1 = list[i];
                    var item2 = list[j];
                    if (item1 + item2 == sum)
                    {
                        var result = new Tuple<int, int>(i, j);
                        return result;
                    }
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            var before = DateTime.Now;
            Debug.WriteLine(before);
            var result = FindTwoSumSlowest(new List<int> {1, 3, 5, 7, 9}, 12);
            var after = DateTime.Now;
            Debug.WriteLine(after);

            TimeSpan span = after - before;
            var ms = span.TotalMilliseconds;

            Debug.WriteLine(ms);

            Debug.WriteLine("----");

            before = DateTime.Now;
            Debug.WriteLine(before);
            result = FindTwoSum(new List<int> { 1, 3, 5, 7, 9 }, 12);
            after = DateTime.Now;
            Debug.WriteLine(after);

            span = after - before;
            ms = span.TotalMilliseconds;

            Debug.WriteLine(ms);
        }
    }
}
