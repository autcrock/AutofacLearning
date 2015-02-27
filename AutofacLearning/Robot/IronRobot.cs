using AutofacLearning.Movables;

namespace AutofacLearning.Robot
{
    public class IronRobot : IMove, IRobot
    {
        private readonly IMove _move;

        public IronRobot(IMove move)
        {
            _move = move;
        }

        public void Moving(string method)
        {
            _move.Moving(method);
        }

        public void RobotMove()
        {
            Moving("withClank");
        }
    }
}