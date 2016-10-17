namespace Kermen.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IToyPlayer : IPerson
    {
        IEnumerable<Toy> Toys { get; }
    }
}
