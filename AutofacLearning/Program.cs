﻿using System;
using Autofac;
using Movables;
using Robot;

namespace AutofacLearning
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleWalk>().As<IMove>();
            builder.RegisterType<IronRobot>().As<IRobot>();

            Container = builder.Build();

            RobotMove();
            Console.ReadLine();
        }

        public static void RobotMove()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var ironRobot = scope.Resolve<IRobot>();
                ironRobot.RobotMove();
            }
        }

    }
}
