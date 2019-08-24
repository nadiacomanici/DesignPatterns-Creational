using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype_ShallowAndDeepClone.Classes
{
    [Serializable]
    [DebuggerDisplay("{FirstName} {LastName}")]
    public class Author : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Author DeepClone()
        {
            return DeepCloner.DeepClone<Author>(this);
        }
    }
}
