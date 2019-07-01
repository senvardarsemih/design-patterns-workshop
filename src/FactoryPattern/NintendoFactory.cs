using FactoryPattern.Base;

namespace FactoryPattern
{
    /// <summary>
    /// concrete factory
    /// </summary>
    public class NintendoFactory :ConsoleFactory
    {
        public override IConsole Create(string version) => new Nintendo(version);
    }
}
