using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; private set; }
        public string Color{ get; private set; }
        public string Model { get; private set; }
        
        public Vehicle() : this("") { }
        public Vehicle(string color) : this(color, 0) { }
        public Vehicle(string color, int maxSpeed) : this(color, maxSpeed, "") { }
        public Vehicle(string color, int maxSpeed, string model)
        {
            this.Color = color;
            this.MaxSpeed = maxSpeed;
            this.Model = model;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }

        public void SetColor(string color)
        {
            this.Color = color;
        }

        public void SetModel(string model)
        {
            this.Model = model;
        }

        public virtual string Info()
        {
            string str = "Model: " + Model + "\nMax speed: " + MaxSpeed + "\nColor: " + Color;
            return str;
        }
    }
}
