using System;
using System.Collections.Generic;
using System.Text;

namespace SabraEjerciciosTestUnit.Domain
{
    public class Bicycle : Vehicle
    {
        public Bicycle() : base()
        {
            setHasEngine(false);
            setWheelNum(2);
        }
    }
}
