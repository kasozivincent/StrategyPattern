using System;
using StrategyDemo.StategyInterfaces;

namespace StrategyDemo
{
    public abstract class Duck
    {
       private IFlyBehaviour flyable;
       private IQuackBehaviour quackable;

       public Duck(IFlyBehaviour flyable, IQuackBehaviour quackable)
       {
            this.flyable = flyable;
            this.quackable = quackable;
       }

        public void Swim()
        {
            Console.WriteLine("I am swimming");
        }

    }
}