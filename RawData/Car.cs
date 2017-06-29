using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire firstTire;
        private Tire secondTire;
        private Tire thirdTire;
        private Tire fourthTire;

        public Car(string model, Engine engine, Cargo cargo, Tire firstTire, Tire secondTire, Tire thirdTire, Tire fourthTire)
        {
            this.model = model;
            this.cargo = cargo;
            this.engine = engine;
            this.firstTire = firstTire;
            this.secondTire = secondTire;
            this.thirdTire = thirdTire;
            this.fourthTire = fourthTire;
        }

        public string Model { get { return this.model; } }
        public Cargo Cargo { get { return this.cargo; } }
        public Tire FirstTire { get {return this.firstTire; } }
        public Tire SecondTire { get {return this.secondTire; } }
        public Tire ThirdTire { get {return this.thirdTire; } }
        public Tire FourthTire { get {return this.fourthTire; } }
        public Engine Engine { get {return this.engine; } }
    }
}
