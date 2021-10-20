using System;
using System.Collections.Generic;

namespace classwrk
{
    class Program
    {
        static void Main(string[] args)
        {
            var bar = new Bar() { Name = "Hyena" };
            bar.Visitors = new List<Visitor>();
            bar.Visitors.Add(new Stalker() { Name = "Hvosch", GroupName = "Svoboda" });
            bar.Visitors.Add(new Biker() { Name = "Ruslik", MotorbikeName = "Purple rocket" });
            bar.Visitors.Add(new Tolchok() { Name = "Dexter", GameName = "Warhammer FB" });
            bar.Visitors.Add(new Visitor() { Name = "Razor"});

            foreach (var visitor in bar.Visitors)
            {
                visitor.WhatHesDoing();
            }

        }
    }
}
