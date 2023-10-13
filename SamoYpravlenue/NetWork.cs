using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SamoYpravlenue
{
	internal class NetWork
	{

		public List<string> Netstations = new List<string>() 
		{
			"192.168.1.254"
			//"192.168.1.133",
			//"192.168.1.134",
			//"192.168.1.135",
			//"192.168.1.136",
			//"192.168.1.137",
		};
		public void PullPacket(string adrdest, byte[] bytes)
		{
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

			IPAddress broadcast = IPAddress.Parse(adrdest);
;
			IPEndPoint ep = new IPEndPoint(broadcast, 443);

			s.SendTo(bytes, ep);

			//Console.WriteLine("hz");
		}

	}
}
