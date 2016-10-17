namespace Problem_10.Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Person
    {
        internal Person(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Parents = new Dictionary<string, string>();
            this.Children = new Dictionary<string, string>();
        }

        internal string Name { get; private set; }

        internal string BirthDate { get; private set; }

        internal IDictionary<string, string> Parents { get; set; }

        internal IDictionary<string, string> Children { get; set; }

        public override string ToString()
        {
            var personBuilder = new StringBuilder();
            personBuilder.Append(this.Name + " " + this.BirthDate + Environment.NewLine);
            personBuilder.Append("Parents: " + Environment.NewLine);
            foreach (var parent in this.Parents)
            {
                personBuilder.Append(parent.Key + " " + parent.Value + Environment.NewLine);
            }
            personBuilder.Append("Children: " + Environment.NewLine);
            foreach (var child in this.Children)
            {
                personBuilder.Append(child.Key + " " + child.Value + Environment.NewLine);
            }

            return personBuilder.ToString();
        }
    }
}
