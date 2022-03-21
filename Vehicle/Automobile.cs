using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleS
{
    public class Automobile : Vehicle
    {
        protected string steeringWheelLocation;
        protected string typeOfDrive;

        public Automobile() : base()
        {
            steeringWheelLocation = "";
            typeOfDrive = "";
        }
        public Automobile(string typeOfDrive, string steeringWheelLocation, double mass, double maxSpeed, double numberOfPassengers) :
            base(mass, maxSpeed, numberOfPassengers)
        {
            this.typeOfDrive = typeOfDrive;
            this.steeringWheelLocation = steeringWheelLocation;
        }
        public Automobile(Automobile copy) : base(copy)
        {
            this.steeringWheelLocation = copy.steeringWheelLocation;
            this.typeOfDrive = copy.typeOfDrive;
        }
        public string SteeringWheelLocation
        {
            get { return this.steeringWheelLocation; }
            set { this.steeringWheelLocation = value; }
        }
        public string TypeOfDrive
        {
            get { return this.typeOfDrive; }
            set { this.typeOfDrive = value; }
        }
        public override string Show()
        {
            string str = base.Show();
            return (str + "\nТип привода: " + typeOfDrive + "\nРасположение руля: " + steeringWheelLocation);
        }
        public new object Clone()
        {
            return new Automobile(this.typeOfDrive, this.steeringWheelLocation, this.mass, this.maxSpeed, this.numberOfPassengers);
        }
        public new Automobile ShallowCopy()
        {
            return (Automobile)this.MemberwiseClone();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Automobile v)
                return this.mass == v.mass && this.maxSpeed == v.maxSpeed && this.numberOfPassengers == v.numberOfPassengers 
                    && this.steeringWheelLocation == v.steeringWheelLocation && this.typeOfDrive == v.typeOfDrive; 
            else return false;
        }
    }
}
