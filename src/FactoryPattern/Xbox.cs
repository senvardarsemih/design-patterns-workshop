using System;
using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete console
    /// </summary>
    public class Xbox: IConsole
    {
        private readonly string _version;

        public Xbox(string version)
        {
            _version = version;
        }

        public void RunTheGame()
        {
            Console.WriteLine($"Running the game on {nameof(Xbox)} {_version} !");
        }
    }
}
