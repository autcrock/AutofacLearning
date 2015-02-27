using AutofacLearning.Coordinates;

namespace AutofacLearning.Movables
{
    public interface IMove {
        void Moving(string movementType);
        void Moving(ICoordinate to);
    }
}