﻿using System;

namespace ECSLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            ITempSensor tempSensor = new TempSensor();
            IHeater heater = new Heater();

            var ecs = new ECS(28, tempSensor,heater);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

            ecs.SetThreshold(26);

            ecs.Regulate();

            //Hej Ditte


        }
    }
}
