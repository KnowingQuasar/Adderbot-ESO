﻿using Discord.WebSocket;
using System;

namespace Adderbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                new Adderbot().StartAsync().GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
