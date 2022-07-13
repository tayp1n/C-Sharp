using System;

namespace ConsoleApp1
{
    public class Notify
    {
        public static void NotifyAboutIll(int type)
        {
            switch (type)
            {
                case 1:
                    Console.WriteLine("Attention! Your Pulse is bad. Possible Heart attack ");
                    break;
                case 2:
                    Console.WriteLine("Attention! Get some rest");
                    break;
                case 3:
                    Console.WriteLine("Attention! Just go");
                    break;
            }
        }
    }
}