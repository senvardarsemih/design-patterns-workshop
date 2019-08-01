using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// concrete factory
    /// </summary>
    public class PlayStationFactory :ConsoleFactory
    {
        public override IConsole Create(string version) => new PlayStation(version);
    }
}
