namespace MuOnline
{
    using System;
    using System.Runtime.CompilerServices;
    using MuOnline.Core;
    using MuOnline.Core.Factories;
    using MuOnline.Core.Factories.Interface;
    using MuOnline.Core.Interfaces;
    using MuOnline.IO.Console.IO;
    using MuOnline.IO.ConsoleIO;
    using MuOnline.IO.Interfaces;
    using MuOnline.Repositories;
    using MuOnline.Repositories.Interfaces;
    using MuOnline.Season_6.Heroes.HeroesStatistics;
    using MuOnline.Season_6.Monsters.MonstersStatistics;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();
            IEngine engine = serviceProvider.GetService<IEngine>();
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IMonsterFactory, MonsterFactory>();
            serviceCollection.AddTransient<IHeroFactory, HeroFactory>();

            serviceCollection.AddTransient<IWriter, ConsoleWriter>();
            serviceCollection.AddTransient<IReader, ConsoleReader>();

            serviceCollection.AddTransient<IEngine, Engine>();

            serviceCollection.AddSingleton<IRepository<IHero>, HeroRepository>();
            serviceCollection.AddSingleton<IRepository<IMonster>, MonsterRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}