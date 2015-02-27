using System;

namespace Movables
{
    public class ConsoleWalk : IMove {
        public void Moving (string movementType) {
            Console.WriteLine(movementType);
        }
    }
}