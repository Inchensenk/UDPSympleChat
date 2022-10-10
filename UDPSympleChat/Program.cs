using System;
using System.Net.Sockets;

namespace UDPSympleChat
{

    class Program
    {
        static int localPort;
        static int remotePort;
        static Socket listeningSocket;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порт для приема сообщений: ");
            localPort = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порт ");
        }
    }
}