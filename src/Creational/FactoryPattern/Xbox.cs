using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete console
    /// </summary>
    public class Xbox : IConsole
    {
        private readonly string _version;

        public Xbox(string version)
        {
            _version = version;
        }

        public string RunTheGame()
        {
            return $"Running the game on {nameof(Xbox)} {_version} !";
        }
    }
}
