using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;

namespace SamoYpravlenue
{
	internal class RSAS
	{
		public List<string> FullRSA()
		{
			List<string> bytes = new List<string>();
			using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
			{
				rsa.KeySize=512;
				string base64string = Convert.ToBase64String(Encoding.UTF8.GetBytes("jiraffy.ru")); //0YLQtdGB0YI=
				byte[] dataToEncrypt = Convert.FromBase64String(base64string);
				byte[] untext = Encript(dataToEncrypt, rsa.ExportParameters(false));
				string text = Decript(untext,rsa.ExportParameters(true));
				string base64 = Convert.ToBase64String(untext);
				bytes.Add(base64);
				bytes.Add(text);
				bytes.Add(base64);
				bytes.Add(text);
				bytes.Add(base64);
				bytes.Add(text);
			}
			bytes[0] = BadBoy(bytes[0]);
			bytes[1] = BadBoy(bytes[1]);
			bytes[2] = BadBoy(bytes[2]);
			bytes[3] = BadBoy(bytes[3]);
			return bytes;
		}
		private byte[] Encript(byte[] text, RSAParameters parameters)
		{
			using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
			{
				provider.ImportParameters(parameters);
				var a = provider.Encrypt(text, false);
				//Console.WriteLine(provider.ToXmlString(false) + "\n");
				return a;
				
			}
		}
		private string Decript(byte[] text, RSAParameters parameters)
		{
			using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
			{ 
				provider.ImportParameters(parameters);
				byte[] a = provider.Decrypt(text, false);
				//Console.WriteLine(provider.ToXmlString(true) + "\n");
				byte[] q1 = Encoding.UTF8.GetBytes(provider.ToXmlString(true));
				return Convert.ToBase64String(q1);
			}
		}
		private string BadBoy(string message)
		{
			Random random = new Random();
			for (int i=0;i<3;i++)
			{
				
				var a = random.Next(50,message.Length);
				message= message.Replace(message[a], '?');
				
			}
			return message;
		}
	}
}
