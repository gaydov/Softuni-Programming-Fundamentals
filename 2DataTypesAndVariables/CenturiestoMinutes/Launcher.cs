﻿using System;

namespace CenturiestoMinutes
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Truncate(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}
