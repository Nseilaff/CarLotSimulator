using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Carlot
    {
        public List<Carlot> Inventory { get; set; } = new List<Carlot>();
        public static int numberOfCars = 0;
    }
       
}
