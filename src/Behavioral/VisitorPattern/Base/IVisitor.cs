namespace VisitorPattern.Base
{
    public interface IVisitor
    {
        string VisitMarvelUniverse(MarvelUniverse marvelElement);

        string VisitDcUniverse(DcUniverse dcElement);
    }
}
