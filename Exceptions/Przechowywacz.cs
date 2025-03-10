using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	internal class Przechowywacz<T>
	{
		T a;
		string b;
		bool c;
		public Przechowywacz()
		{
            Console.WriteLine(a+" "+b+" "+c);
        }
		public void setData(T a, string b)
		{
			Console.WriteLine(a + " " + b);
		}
	}
}
