using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestComponent3
{
    public class Class1
    {
        public void DoStuff()
        {
            var c = new TestComponent2.Class1();
            var name = c.GetName();
            System.Diagnostics.Debug.WriteLine(name);
        }
    }
}
