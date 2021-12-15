using Aircompany.Models;
using Aircompany.Planes;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> Planes { get; private set; }
        public List<PassengerPlane> PassengerPlanes => Planes.Where(x => x is PassengerPlane).Select(x => (PassengerPlane)x).ToList();
        public List<MilitaryPlane> MilitaryPlanes => Planes.Where(x => x is MilitaryPlane).Select(x => (MilitaryPlane)x).ToList();


        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return PassengerPlanes.Aggregate((x, y) => x.PassengersCapacity > y.PassengersCapacity ? x : y);             
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return MilitaryPlanes.Where(x => x.Type == MilitaryType.Transport).ToList();
        }

        public Airport SortByMaxDistance()
        {
            Planes = Planes.OrderBy(x => x.MaxFlightDistance).ToList();
            return this;
        }

        public Airport SortByMaxSpeed()
        {
            Planes = Planes.OrderBy(x => x.MaxSpeed).ToList();
            return this;
        }

        public Airport SortByMaxLoadCapacity()
        {
            Planes = Planes.OrderBy(x => x.MaxLoadCapacity).ToList();
            return this;
        }

        public override string ToString()
        {
            return $"Airport{{planes={string.Join(", ", Planes.Select(x => x.Model))}}}";
        }
    }
}