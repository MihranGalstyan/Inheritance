using System;

namespace Inheritance
{
    class BaseClass
    {
        public int baseNumber;

        public int field1;
        public int field2;
        public int field3;

        // Public field of Base class
        public string publicField = "BaseClass.PublicField";

        // Private field of Base class
        private string privateField = "BaseClass.PrivateField";

        // Protected field of Base class
        protected string protectedField = "BaseClass.ProtectedField";

        public void Show()
        {
            Console.WriteLine(privateField);
        }

        public BaseClass()
        {
        }

        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
