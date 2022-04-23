using System;
using System.Collections.Generic;
using System.Text;

namespace SabraEjerciciosTestUnit.Domain
{
    public class Vehicle
    {
        public int WheelNum { get; private set; } 
        public bool HasEngine { get; private set; }

        public void setWheelNum(int number)
        {
           this.WheelNum = number;
        }

        public void setHasEngine(bool HasEngine)
        {
           this.HasEngine = HasEngine;
        }

    }
}
