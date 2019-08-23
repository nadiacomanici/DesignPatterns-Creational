using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype_ShallowAndDeepClone.Classes
{
    [Serializable]
    public class Book : ICloneable
    {
        public string Title { get; private set; }
        public Author Author { get; set; }

        public Book(string title, Author author)
        {
            Author = author;
            Title = title;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Book DeepClone()
        {
            return DeepCloner.DeepClone<Book>(this);
        }
    }
}
