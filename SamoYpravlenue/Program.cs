using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamoYpravlenue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			NetWork netWork = new NetWork();
			List<string> iphosts = netWork.Netstations;
			Console.WriteLine($"Хостов - {iphosts.Count}");
			Console.WriteLine("START!");


			//RSAS rSAS = new RSAS();
			//var list = rSAS.FullRSA();
			//for (int i = 0; i < iphosts.Count; i++)
			//	for (int j = 0; j < 6; j++)
			//	{

			//		netWork.PullPacket(iphosts[i], Encoding.UTF8.GetBytes("sometext"));
			//	}
			int i = 0;
			while (i < 100000)
			{
				Console.WriteLine(i);
				netWork.PullPacket(iphosts[0], Encoding.UTF8.GetBytes("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"));
				i++;
			}

				
			Console.WriteLine("All");

			Console.ReadLine();
		}
	}
}
