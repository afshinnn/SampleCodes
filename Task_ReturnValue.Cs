// page 12
using System;
using System.Threading.Tasks;

namespace Chapter1
{
  public static class Program
  {
	  public static void Main()
		{
			Task<int> t = Task.Run(() =>
			{
				return 42;
			});
			// forces the application to wait for task results
			Console.WriteLine(t.Result); // Displays 42
		}
	}
}
