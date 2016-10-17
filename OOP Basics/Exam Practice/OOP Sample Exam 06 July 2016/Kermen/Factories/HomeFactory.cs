namespace Kermen.Factories
{
    using System;
    using System.Collections.Generic;

    using Kermen.Models.Interfaces;

    public class HomeFactory
    {
        public static IHome CreateHome(string homeType, IList<IList<double>> commandParams)
        {
            var type = Type.GetType("Kermen.Models." + homeType);
            var home = (IHome)Activator.CreateInstance(type, commandParams);

            return home;
        }
    }
}
