using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        public int field4;
        public int field5;


        // Class constructor
        /*
        public DerivedClass(int num)
        {
        }
        */

        public DerivedClass()
        {
            publicField = "DerivedClassPublicField";
            protectedField = "DerivedClassProtectedField";
        }

        /*
        public DerivedClass(int num1, int num2)
        {
            baseNumber = num1;
            derivedField = num2;
        }
        */
        /*
        public DerivedClass(int num1, int num2)
            : this(num1)
        {
            derivedField = num2;
        }
        */

        public DerivedClass(int num1, int num2)
           : base(num1)
        {
            derivedField = num2;
        }
    }
}
