﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit payment plan calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
