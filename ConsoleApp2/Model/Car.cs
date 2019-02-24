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
        //public int CountWheels { get; set; }
        public static int CountWheels = 4;

        public Car() : this("","","",0,"") { } 
        public Car(string engineType) : this(engineType, "", "", 0, "") { }      
        public Car(string engineType, string transmissionBox) : this(engineType, transmissionBox, "", 0, "") { }
        //public Car(string engineType, string transmissionBox, int countWheels) : this(engineType, transmissionBox, countWheels, "", 0, "") { }
        public Car(string engineType, string transmissionBox, string color) : this(engineType, transmissionBox, color, 0, "") { }
        public Car(string engineType, string transmissionBox, string color, int maxSpeed) : this(engineType, transmissionBox, color, maxSpeed, "") { }
        public Car(string engineType, string transmissionBox, string color, int maxSpeed, string model) : base(color, maxSpeed, model)
        {
            this.EngineType = engineType;
            this.TransmissionBox = transmissionBox;
           // this.CountWheels = countWheels;   
        }
        public static int getCountWheels()
        {
            return CountWheels;
        }
        public override string Info()
        {
            string str = base.Info();
            return str += "\nEngine type: " + EngineType + "\nTransmission box: " + TransmissionBox + "\nCount wheels: " + CountWheels;
        }

    }
}
