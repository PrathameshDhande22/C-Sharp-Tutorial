using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyClassTwo : AssemblyClassOne
    {
        public void Method()
        {
            // calling the internal member from AssemblyOne
            AssemblyClassOne as1c = new AssemblyClassOne();
            //as1c.pincode;// not Accessible bcoz it is available only within the assembly

            // Accessing the protected internal members
            this.Address = "Vashi";
            base.Address = "Panvel";
        }
    }

    class AssemblyClassTwoBrother
    {
        public void Method()
        {
            AssemblyClassTwo as2c = new AssemblyClassTwo();
            //as2c.Address; not accessible bcoz it is available only within the assembly and class derived by it.
        }
    }
}

