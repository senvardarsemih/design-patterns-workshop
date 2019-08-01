namespace FactoryPattern.Base
{
    /// <summary>
    /// factory creator for consoles
    /// </summary>
    public abstract class ConsoleFactory
    {
        public abstract IConsole Create(string version);
    }
}
