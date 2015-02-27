namespace AutofacLearning.Coordinates
{
    public interface ICoordinate
    {
        double StraightLineDistance(ICoordinate anotherCoordinate);
        double X();
        double Y();
        double Z();
    }
}
