using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleS
{
    public class ExpressTrain : Train
    {
        protected string nameTrain;
        protected int numberOfClasses;

        public ExpressTrain() : base()
        {
            nameTrain = "";
            numberOfClasses = 0;
        }
        public ExpressTrain(string nameTrain, int numberOfClasses, int numberOfVagons, string route, double mass, double maxSpeed, double numberOfPassengers)
            : base(numberOfVagons, route, mass, maxSpeed, numberOfPassengers)
        {
            this.nameTrain = nameTrain;
            this.numberOfClasses = numberOfClasses;
        }
        public ExpressTrain(ExpressTrain copy) : base(copy)
        {
            this.nameTrain=copy.nameTrain;
            this.numberOfClasses = copy.numberOfClasses;
        }
        public int NumberOfClasses
        {
            get { return this.numberOfClasses; }
            set
            {
                if (value >= 0) this.numberOfClasses = value;
                else this.numberOfClasses = 0;
            }
        }
        public string NameTrain
        {
            get { return this.nameTrain; }
            set { this.nameTrain = value; }
        }
        public override string Show()
        {
            string str = base.Show();
            return (str + "\nНазвание поезда: " + nameTrain + "\nКоличество категорий билетов = " + numberOfClasses);
        }
        public new int CompareTo(object obj)
        {
            ExpressTrain tmp = (ExpressTrain)obj;
            if (String.Compare(this.nameTrain, tmp.nameTrain) > 0) return 1;
            if (String.Compare(this.nameTrain, tmp.nameTrain) < 0) return -1;
            return 0;
        }
        public new object Clone()
        {
            return new ExpressTrain(this.nameTrain, this.numberOfClasses, this.numberOfVagons, this.route, this.mass, this.maxSpeed, this.numberOfPassengers);
        }
        public new ExpressTrain ShallowCopy()
        {
            return (ExpressTrain)this.MemberwiseClone();
        }
        public override bool Equals(object? obj)
        {
            if (obj is ExpressTrain v)
                return this.mass == v.mass && this.maxSpeed == v.maxSpeed && this.numberOfPassengers == v.numberOfPassengers && this.nameTrain == v.nameTrain && this.numberOfClasses == v.numberOfClasses
                    && this.numberOfVagons == v.numberOfVagons && this.route == v.route;
            else return false;
        }
    }
}
