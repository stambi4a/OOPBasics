namespace Problem_07.The_Immutable_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        private static void Main(string[] args)
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }
        }
    }

    public class ImmutableList
    {
        public ICollection<int> numberCollection;

        public ImmutableList(ICollection<int> collection)
        {
            this.numberCollection = collection;
        }

        public ImmutableList GetCollection()
        {
            return new ImmutableList(this.numberCollection.Select(item => item).ToList());
        }
    }
}
