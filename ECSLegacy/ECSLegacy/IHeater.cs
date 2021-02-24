using System;
using System.Collections.Generic;
using System.Text;

namespace ECSLegacy
{
    public interface IHeater
    {
        public void TurnOn();

        //tester
        public void TurnOff();


        public bool RunSelfTest();
    }
}
