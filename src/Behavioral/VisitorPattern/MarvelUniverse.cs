using VisitorPattern.Base;

namespace VisitorPattern
{
    public class MarvelUniverse : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitMarvelUniverse(this);
        }

        public string ExclusiveCharacterOfMarvelUniverse()
        {
            return "Thanos";
        }

        public string ExclusiveComicBookOfMarvelUniverse()
        {
            return "Deadpool";
        }
    }
}
