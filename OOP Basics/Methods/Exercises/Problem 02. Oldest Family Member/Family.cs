/*
namespace Problem_02.Oldest_Family_Member
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers { get; set; }

        public void AddMember(Person member)
        {
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            var maxAge = this.FamilyMembers.Max(member => member.Age);
            var oldestMember = this.FamilyMembers.First(member => member.Age == maxAge);

            return oldestMember;
        }
    }
}
*/
