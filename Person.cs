using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures
{
    public class Person
    {
        // Third Feature : 
        // the "init" means it can only be declared ONCE
        public int YearOfBirth { get; init; } 
        public string Name;
    }
}
