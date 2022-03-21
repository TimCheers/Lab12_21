using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VehicleS
{
    public class Vehicle : IComparable, ICloneable, IExecutable
    {
        protected double mass;
        protected double maxSpeed;
        protected double numberOfPassengers;

        public Vehicle()
        {
            mass = 0;
            maxSpeed = 0;
            numberOfPassengers = 0;
        }
        public Vehicle(double mass, double maxSpeed, double numberOfPassengers)
        {
            this.mass = mass;
            this.maxSpeed = maxSpeed;
            this.numberOfPassengers = numberOfPassengers;
        }
        public Vehicle(Vehicle copy)
        {
            this.mass=copy.mass;
            this.maxSpeed=copy.maxSpeed;
            this.numberOfPassengers=copy.numberOfPassengers;
        }
        public double Mass
        {
            get { return this.mass; }
            set
            {
                if (value >= 0) this.mass = value;
                else this.mass = 0;
            }
        }
        public double MaxSpeed
        {
            get { return this.maxSpeed; }
            set
            {
                if (value >= 0) this.maxSpeed = value;
                else this.maxSpeed = 0;
            }
        }
        public double NumberOfPassengers
        {
            get { return this.numberOfPassengers; }
            set
            {
                if (value >= 0) this.numberOfPassengers = value;
                else this.numberOfPassengers = 0;
            }
        }
        public virtual string Show()
        {
            return ("Масса = " + mass + " Тонн\nМаксимальная скорость = " + maxSpeed + " км/ч\nКоличество пассажиров = " + numberOfPassengers);
        }
        public int CompareTo(object obj)
        {
            Vehicle tmp = (Vehicle)obj;
            if (this.maxSpeed > tmp.maxSpeed) return 1;
            if (this.maxSpeed < tmp.maxSpeed) return -1;
            return 0;
        }
        private class SortBynumberOfPassengersHelper : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Vehicle A = (Vehicle)x;
                Vehicle B = (Vehicle)y;
                if (A.numberOfPassengers > B.numberOfPassengers) return 1;
                if (A.numberOfPassengers < B.numberOfPassengers) return -1;
                return 0;
            }
        }
        public static IComparer SortBynumberOfVagons()
        {
            return (IComparer)new SortBynumberOfPassengersHelper();
        }
        public Vehicle ShallowCopy()
        {
            return (Vehicle)this.MemberwiseClone();
        }
        public object Clone()
        {
            return new Vehicle(this.mass, this.maxSpeed, this.numberOfPassengers);
        }
        public override bool Equals(object? obj)
        {
            if (obj is Vehicle v)
                return this.mass == v.mass && this.maxSpeed==v.maxSpeed && this.numberOfPassengers==v.numberOfPassengers;
            else return false;
        }
    }
}
