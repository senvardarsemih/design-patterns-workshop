using System;
using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete console
    /// </summary>
    public class Nintendo : IConsole
    {
        private readonly string _version;

        public Nintendo(string version)
        {
            _version = version;
        }

        public string RunTheGame()
        {
            return $"Running the game on {nameof(Nintendo)} {_version} !";
        }
    }
}
