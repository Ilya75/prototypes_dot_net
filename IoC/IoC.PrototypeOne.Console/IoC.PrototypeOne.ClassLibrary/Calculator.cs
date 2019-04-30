using System;

namespace IoC.PrototypeOne.ClassLibrary
{
    public class Calculator<T> : ICalculator<T> where T : IComparable<T>
    {
        public T Add(T paramOne, T paramTwo)
        {
            return (dynamic)paramOne + (dynamic)paramTwo;
        }

        public T Divide(T paramOne, T paramTwo)
        {
            return (dynamic)paramOne / (dynamic)paramTwo;
        }

        public T Multiply(T paramOne, T paramTwo)
        {
            return (dynamic)paramOne * (dynamic)paramTwo;
        }

        public T Subtract(T paramOne, T paramTwo)
        {
            return (dynamic)paramOne - (dynamic)paramTwo;
        }
    }
}
