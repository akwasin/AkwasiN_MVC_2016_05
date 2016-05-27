using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkwasiN_MVC_2016_05
{
    public class Uppgift3
    {
        public float GetCurrentSpeed(int distance, int time)
        {
            float speed = distance/time;
            return speed;
            //throw new NotImplementedException();
        }

        public float TestingMethod()
        {
            return GetCurrentSpeed(20,5);
        }
    }
}
