namespace Kermen.Data.Interfaces
{
    using System.Collections.Generic;

    using Kermen.Models.Interfaces;

    public interface IDatabase
    {
        ICollection<IHome> Homes { get; }
    }
}
