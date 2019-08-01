using VisitorPattern.Base;

namespace VisitorPattern
{
    public class CharacterVisitor : IVisitor
    {
        public string VisitMarvelUniverse(MarvelUniverse element)
        {
            return element.ExclusiveCharacterOfMarvelUniverse();
        }

        public string VisitDcUniverse(DcUniverse element)
        {
            return element.ExclusiveCharacterOfDcUniverse();
        }
    }
}
