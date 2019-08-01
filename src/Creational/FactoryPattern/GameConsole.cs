using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// wrapper class for operations
    /// </summary>
    public class GameConsole
    {
        private readonly Dictionary<ConsoleTypes, ConsoleFactory> _factories;
        private GameConsole()
        {
            _factories = new Dictionary<ConsoleTypes, ConsoleFactory>();

            foreach (ConsoleTypes action in Enum.GetValues(typeof(ConsoleTypes)))
            {
                var factory = (ConsoleFactory)Activator.CreateInstance(Type.GetType(typeof(GameConsole).Namespace + "." + Enum.GetName(typeof(ConsoleTypes), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        public static GameConsole InitializeFactories() => new GameConsole();

        public IConsole ExecuteCreation(ConsoleTypes console, string version) => _factories[console].Create(version);
    }
}
