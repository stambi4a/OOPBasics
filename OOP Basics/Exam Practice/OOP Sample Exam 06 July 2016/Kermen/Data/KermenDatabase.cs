namespace Kermen.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Kermen.Data.Interfaces;
    using Kermen.Models.Interfaces;

    public class KermenDatabase : IDatabase
    {
        public KermenDatabase()
        {
            this.Homes = new List<IHome>();
        }

        public ICollection<IHome> Homes { get; }
    }
}
