﻿namespace AnimalFarm
{
    using System;

    public class Chicken
    {
        private string name;
        private int age;

        protected string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        protected int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;

                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;

                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;

                default:
                    return 0.75;
            }
        }

        public override string ToString()
        {
            return $"Chicken {this.name} (age {this.age}) can produce {this.ProductPerDay} eggs per day.";
        }
    }
}