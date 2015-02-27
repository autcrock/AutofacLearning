using System;

namespace AutofacLearning.Coordinates
{
    class Coordinate : ICoordinate
    {
        public double _x { get; set; }
        public double _y { get; set; }
        public double _z { get; set; }

        public Coordinate( Double x, Double y, Double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double X()
        {
            return _x;
        }

        public double Y()
        {
            return _y; 
        }

        public double Z()
        {
            return _z;
        }

        public double StraightLineDistance(ICoordinate anotherCoordinate)
        {

            return Math.Sqrt(
                Math.Pow((anotherCoordinate.X() - _x), 2.0)
                + Math.Pow((anotherCoordinate.Y() - _y), 2.0)
                + Math.Pow((anotherCoordinate.Z() - _z), 2.0)
                );
        }
    }
}
