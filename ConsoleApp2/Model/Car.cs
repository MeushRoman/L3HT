using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Model
{
    
    public class Car : Vehicle
    {
        public string EngineType { get; set; }
        public string TransmissionBox { get; set; }
        public int CountWheels { get; set; }

        public Car() : this("","",4,"",0,"") { } 
        public Car(string engineType) : this(engineType, "", 4, "", 0, "") { }      
        public Car(string engineType, string transmissionBox) : this(engineType, transmissionBox, 4, "", 0, "") { }
        public Car(string engineType, string transmissionBox, int countWheels, string color) : this(engineType, transmissionBox, countWheels, color, 0, "") { }
        public Car(string engineType, string transmissionBox, int countWheels, string color, int maxSpeed) : this(engineType, transmissionBox, countWheels, color, maxSpeed, "") { }
        public Car(string engineType, string transmissionBox, int countWheels, string color, int maxSpeed, string model) : base(color, maxSpeed, model)
        {
            this.EngineType = engineType;
            this.TransmissionBox = transmissionBox;
            this.CountWheels = countWheels;   
        }

        public override string Info()
        {
            string str = base.Info();
            return str += "\nEngine type: " + EngineType + "\nTransmission box: " + TransmissionBox + "\nCount wheels: " + CountWheels;
        }

    }
}
