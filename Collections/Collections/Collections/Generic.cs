using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // We can have multiple generic parametres, separated by comma, for example internal class Generic<T,S,P>
    internal class Generic<T>
    {
        public T _value;

        public Generic(T value)
        {
            _value = value;
        }

        public bool Compare<T2>(T2 t2)
        {
            if (t2 is not null)
                return t2.Equals(_value);
            else return false;
        }
    }


    // We can specify, that generic parameter T can be any class BUT that class has to implement specific Interface
    internal class GenereicWithCondition<T> where T : IComparable
    {

    }

    // With new keyword we can create instances of that specific type contained in T parameter
    internal class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    public class InheritanceSpecified<A, B, C> where A : B, new() 
                                               where B : C, new()
                                               where C : new()
    {
        public A CreateInstanceA()
        {
            return new A();
        }
        public B CreateInstanceB()
        {
            return new B();
        }
        public C CreateInstanceC()
        {
            return new C();
        }
    }
}
