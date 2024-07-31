using System;

namespace AssemblyOne
{
    public class AssemblyClassOne
    {
        // Internal Member
        internal int pincode = 401502;

        // Internal Protected
        protected internal string Address;


    }

    // Internal Class
    internal class AssemblyClassOneInternal
    {
        public void Call()
        {
            Console.WriteLine("Calling the Internal Class");    
        }
    }
}

namespace AssemblyOneBrother
{
    public class AssemblyOneBrotherClass
    {
        // internal member
        internal int streetNo = 100;

        // Accessing the internal member from here
        public void MethodONE()
        {
            AssemblyOne.AssemblyClassOne as1c = new AssemblyOne.AssemblyClassOne();
            as1c.pincode = 401504;

            // Accessing the Internal Protected Member
            as1c.Address = "Boisar";

            // Accessing the Internal Class
            AssemblyOne.AssemblyClassOneInternal as2=new AssemblyOne.AssemblyClassOneInternal();
            

        }
    }
}