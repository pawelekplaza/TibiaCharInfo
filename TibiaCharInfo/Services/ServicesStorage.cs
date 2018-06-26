using System;

namespace TibiaCharInfo.Services
{
    public static class ServicesStorage
    {
        private static ServicesContainer _instance;

        public static ServicesContainer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServicesContainer();
                return _instance;
            }
        }

        public static void RegisterServices()
        {
            Register<ICharacterService, CharacterService>();
            Register<IHighscoreService, HighscoreService>();
        }

        private static void Register<Interface, TConcrete>()    where TConcrete : new()
                                                                where Interface : class
        {
            Instance.Register<Interface, TConcrete>();
        }
    }
}
