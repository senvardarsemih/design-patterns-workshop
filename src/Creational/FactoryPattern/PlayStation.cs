using System;
using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete console
    /// </summary>
    public class PlayStation : IConsole
    {
        private readonly string _version;

        public PlayStation(string version)
        {
            _version = version;
        }

        public string RunTheGame()
        {
            return $"Running the game on {nameof(PlayStation)} {_version} !";
        }
    }
}
