using Movables;

namespace Robot
{
    public class IronRobot : IMove, IRobot
    {
        private IMove _move;

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