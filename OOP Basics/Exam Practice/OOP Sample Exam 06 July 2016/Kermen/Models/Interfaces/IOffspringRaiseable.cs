namespace Kermen.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IOffspringRaiseable
    {
        ICollection<Child> Children { get; }
    }
}
