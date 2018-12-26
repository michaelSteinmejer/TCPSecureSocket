using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TCPSecureSocket
{
    class Program
    {

        static void Main(string[] args)
        {

            //double value=0;

            UdpClient udpServer = new UdpClient(7000);
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 7000);

            try
            {
                while (true)
                {

                    Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);
                    Console.WriteLine(receivedData);
                    //if (receivedData.ToLower().Contains("stop"))
                    //{
                    //    break;
                    //}
                    //string[] datarecieved = receivedData.Split('\n');

                    //var CO = datarecieved[3].Split(':');
                    //string blah = CO[1];
                    //double co = double.Parse(blah);
                    //var NOx = datarecieved[4].Split(':');
                    //var nox = double.Parse(NOx[1]);


                    //value = value + (co+nox);


                    // Console.WriteLine(co);
                    //Console.WriteLine($"CO: {co} \r\nNOx: {nox} ");
                }
                //Console.Clear();
                //Console.WriteLine($"Sum: {value}");
                //Console.WriteLine("Press any key to continue....");
                //Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }
    }
}
