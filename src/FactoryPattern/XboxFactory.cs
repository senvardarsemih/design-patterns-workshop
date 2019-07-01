using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// concrete factory
    /// </summary>
    public class XboxFactory :ConsoleFactory
    {
        public override IConsole Create(string version) => new Xbox(version);
    }
}
