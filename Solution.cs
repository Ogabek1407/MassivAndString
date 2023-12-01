using System;
namespace Test2
{
	public class Solution
	{

		public int Max1;
        public int Min1;


        public Solution()
		{
		}


		public int[] func1(string value,string source)
		{
			List<int> data = new List<int>();
			
			for (int i = 0; i < source.Length-value.Length+1; i++)
			{
				if (source.Substring(i, value.Length) == value)
				{
					data.Add(i);
					if (i > Max1)
					{
						Max1 = i;
					}
					else if (i < Min1)
					{
						Min1 = i;
					}
				}
			}

			return data.ToArray();
		}


		public int[] func2(int[][] values,int length,int count)
		{

			int[] data = new int[Max1+1];
			List<int> resoult = new List<int>();
			for (int i = 0; i < values.Length; i++)
			{
				for (int j = 0; j < values[i].Length; j++)
				{
					data[values[i][j]] = 1;
				}
			}

			

			for (int i = Min1; i < Max1; i++)
			{
				if (data[i] == 1)
				{
					if (func3(data, i, length, count))
					{
						resoult.Add(i);
					}
				}
			}
			

			return resoult.ToArray();
		}


		public bool func3(int[] values,int index,int length,int count)
		{

			for (int i = 0; i < count; i++)
			{
				if (values[index] == 1)
				{
					index += length;
					if (index >= values.Length)
						return false;
				}
				else
				{
					return false;
				}
			}

			return true;
		}


		public int[] Solve(string[] values,string source)
		{
			int[][] data = new int[values.Length][];

			Min1 = source.Length;

			for (int i = 0; i < values.Length; i++)
			{
				data[i] = func1(values[i], source);
			}

			var resuolt=func2(data, values[0].Length,values.Length);


			return resuolt;
		}



    }
}

