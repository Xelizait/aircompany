using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int PassengersCapacity { get; private set; }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            return obj is PassengerPlane plane && 
                   base.Equals(obj) && 
                   PassengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PassengersCapacity.GetHashCode();
            return hashCode;
        }
       
        public override string ToString()
        {
            return base.ToString().Replace("}", $", passengersCapacity={PassengersCapacity}}}");
        }       
        
    }
}
