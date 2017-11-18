using System;
using MyClasses;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine("1. derivedClass.BasseMethod1() ==> {0}",
                derivedClass.BaseMethod1());
            Console.WriteLine("2. derivedClass.BasseMethod2() ==> {0}",
                derivedClass.BaseMethod2());

            BaseClass baseClass = derivedClass;
            Console.WriteLine("3. baseClass.BasseMethod1() ==> {0}",
                baseClass.BaseMethod1());
            Console.WriteLine("4. baseClass.BasseMethod2() ==> {0}",
                baseClass.BaseMethod2());

            Console.ReadKey();
        }
    }
}

namespace MyClasses
{
    public class BaseClass
    {
        public string BaseMethod1()
        {
            return ("In Base.BaseMethod1");
        }

        public virtual string BaseMethod2()
        {
            return ("In Base.BaseMethod2");
        }
    }

    public class DerivedClass : BaseClass
    {
        new public string BaseMethod1()         // <==
        {
            return ("In DerivedClass.BaseMethod1");
        }

        public override string BaseMethod2()
        {
            return ("In DerivedClass.BaseMethod2");
        }
    }
}


/*
OUTPUT:
1. derivedClass.BasseMethod1() ==> In Base.BaseMethod1  ///In DerivedClass.BaseMethod1
2. derivedClass.BasseMethod2() ==> In DerivedClass.BaseMethod2
3. baseClass.BasseMethod1() ==> In Base.BaseMethod1
4. baseClass.BasseMethod2() ==> In Base.BaseMethod2



Knowing When to Use Override and New Keywords 

new - hides

override - extends





*/
