﻿using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }

        public Car (int year, string make , string model, string engineNoise, string honkNoise, bool isDriveable )
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;


        }

        
        public int Year { get; set; } 
        public string Model { get; set; }  
        public string Make { get; set; } 
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; } 
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise(string engineNoise)
        {
            return engineNoise;
        }

        public string MakeHonkNoise(string honkNoise)
        {
            return honkNoise;
        }
    }
}

