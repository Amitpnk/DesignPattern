//using System;

//namespace DecoratorDesignPattern
//{
//    public abstract class Component
//    {
//        abstract public void Operation();
//    }

//    public class ConcreteComponent : Component
//    {
//        public override void Operation()
//        {
//            Console.WriteLine("ConcreteCommponent::Operation()");
//        }
//    }

//    public class Decorator : Component
//    {
//        private Component comp;
//        public Decorator(Component obj)
//        {
//            comp = obj;
//        }

//        public override void Operation()
//        {
//            Console.WriteLine("Component::Operation()");
//            comp.Operation();
//        }
//    }

//    public class ConcreteDecoratorA : Decorator
//    {
//        private int addedState;
//        public ConcreteDecoratorA(Component obj) : base(obj)
//        {
//            addedState = 0;
//        }

//        public override void Operation()
//        {
//            base.Operation();
//            addedState = 1;
//            Console.WriteLine("ConcreteDecoratorA::Operation()");
//            Console.WriteLine($"ConcreteDecoratorA::addedState = {addedState}");
//        }
//    }


//    public class ConcreteDecoratorB : Decorator
//    {

//        public ConcreteDecoratorB(Component obj) : base(obj)
//        {

//        }

//        public override void Operation()
//        {
//            base.Operation();

//            Console.WriteLine("ConcreteDecoratorB::Operation()");

//        }

//        private void AddedBehavior()
//        {
//            Console.WriteLine($"ConcreteDecoratorB::AddedBehavior");
//        }


//    }
//}
