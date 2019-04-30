using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.PrototypeOne.ClassLibrary
{
    public interface ICalculator <T>
    {
        T Add(T paramOne, T paramTwo);
        T Subtract(T paramOne, T paramTwo);
        T Divide(T paramOne, T paramTwo);
        T Multiply(T paramOne, T paramTwo);
    }
}
