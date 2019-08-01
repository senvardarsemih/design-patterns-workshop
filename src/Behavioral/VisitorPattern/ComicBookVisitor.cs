using VisitorPattern.Base;

namespace VisitorPattern
{
    public class ComicBookVisitor : IVisitor
    {
        public string VisitMarvelUniverse(MarvelUniverse element)
        {
            return element.ExclusiveComicBookOfMarvelUniverse();
        }

        public string VisitDcUniverse(DcUniverse element)
        {
            return element.ExclusiveComicBookOfDcUniverse();
        }
    }
}
