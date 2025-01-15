namespace Class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessFields();
            derivedClass.ShowFields();

            Console.ReadKey();
        }

        class BaseClass
        {
            // access modifiers
            public int publicField;
            protected int protectedField;
            private int privateField;

            public void ShowFields()
            {
                Console.WriteLine(
                    $"Public: {publicField}, " +
                    $"Protected: {protectedField}, " +
                    $"Private: {privateField}.");
            }
        }

        class DerivedClass : BaseClass
        {
            public void AccessFields()
            {
                publicField = 1;
                protectedField = 2;
                // privateField = 3; // It won't work.
            }
        }
    }
}
