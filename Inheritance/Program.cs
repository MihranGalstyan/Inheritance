using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.publicField);

            Console.WriteLine(instance.baseNumber);

            Console.WriteLine(instance.derivedField);

            instance.Show();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;

            instance.field4 = 4;
            instance.field5 = 5;

            BaseClass newInstance = (BaseClass)instance;

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            //Console.WriteLine(newInstance.field4);
            //Console.WriteLine(newInstance.field5);





            //Delay
            Console.ReadKey();
        }
}
}
