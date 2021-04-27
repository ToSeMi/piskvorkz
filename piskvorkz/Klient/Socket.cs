using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace piskvorkz.Klient
{
    class Socket
    {
        TcpListener naslouchac;
        bool pripojen;

        public Socket(int port)
        {
            naslouchac = new TcpListener(IPAddress.Any, port);
            pripojen = true;
            naslouchac.Start();
            Pripoj();
        }

        void Pripoj()
        {
            TcpClient tcp = naslouchac.AcceptTcpClient();
            new Thread(new ParameterizedThreadStart(Obsluz)).Start(tcp);
        }

        void Obsluz(object klient)
        {
            TcpClient client = (TcpClient)klient;
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());


            
        }

    }
}
