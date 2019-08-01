using VisitorPattern.Base;

namespace VisitorPattern
{
    public class DcUniverse : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitDcUniverse(this);
        }

        public string ExclusiveCharacterOfDcUniverse()
        {
            return "Superman";
        }

        public string ExclusiveComicBookOfDcUniverse()
        {
            return "Wonder Woman";
        }
    }
}
