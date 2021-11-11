using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType _type;
        public MilitaryType Type
        {
            get { return _type; }
            private set
            {
                _type = value;
            }
        }

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            Type = type;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   _type == plane._type;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _type.GetHashCode();
        }

        //public MilitaryType PlaneTypeIs()
        //{
        //    return _type;
        //}

        public override string ToString() => base.ToString().Replace("}", $", type={Type}}}");
    }
}
