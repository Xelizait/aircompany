using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                _maxSpeed = value;
            }
        }

        private int _maxFlightDistance;
        public int MaxFlightDistance
        {
            get { return _maxFlightDistance; }
            set
            {
                _maxFlightDistance = value;
            }
        }

        private int _maxLoadCapacity;
        public int MaxLoadCapacity
        {
            get { return _maxLoadCapacity; }
            set
            {
                _maxLoadCapacity = value;
            }
        }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            _model = model;
            _maxSpeed = maxSpeed;
            _maxFlightDistance = maxFlightDistance;
            _maxLoadCapacity = maxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + _model + '\'' +
                ", maxSpeed=" + _maxSpeed +
                ", maxFlightDistance=" + _maxFlightDistance +
                ", maxLoadCapacity=" + _maxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   _model == plane._model &&
                   _maxSpeed == plane._maxSpeed &&
                   _maxFlightDistance == plane._maxFlightDistance &&
                   _maxLoadCapacity == plane._maxLoadCapacity;
        }

        public override int GetHashCode()
        {
            return _model.GetHashCode() ^ _maxSpeed.GetHashCode() ^ _maxFlightDistance.GetHashCode() ^ _maxLoadCapacity.GetHashCode();
        }

    }
}
