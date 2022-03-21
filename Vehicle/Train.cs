using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleS
{
    public class Train : Vehicle
    {
        protected int numberOfVagons;
        protected string route;

        public Train() : base()
        {
            numberOfVagons = 0;
            route = "";
        }
        public Train(int numberOfVagons, string route, double mass, double maxSpeed, double numberOfPassengers)
            : base(mass, maxSpeed, numberOfPassengers)
        {
            this.numberOfVagons = numberOfVagons;
            this.route = route;
        }
        public Train(Train copy): base(copy)
        {
            this.route=copy.route;
            this.numberOfVagons = copy.numberOfVagons;
        }
        public int NumberOfVagons
        {
            get { return this.numberOfVagons; }
            set
            {
                if (value >= 0) this.numberOfVagons = value;
                else this.numberOfVagons = 0;
            }
        }
        public string Route
        {
            get { return this.route; }
            set { this.route = value; }
        } 
        public override string Show()
        {
            string str = base.Show();
            return (str + "\nКоличество вагонов = " + numberOfVagons + "\nМаршрут: " + route);
        }
        public new object Clone()
        {
            return new Train(this.numberOfVagons, this.route, this.mass, this.maxSpeed, this.numberOfPassengers);
        }
        public new Train ShallowCopy()
        {
            return (Train)this.MemberwiseClone();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Train v)
                return this.mass == v.mass && this.maxSpeed == v.maxSpeed && this.numberOfPassengers == v.numberOfPassengers && this.numberOfVagons == v.numberOfVagons && this.route == v.route;
            else return false;
        }
    }
}
