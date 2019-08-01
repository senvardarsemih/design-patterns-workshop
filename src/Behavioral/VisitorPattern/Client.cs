using System.Collections.Generic;
using VisitorPattern.Base;

namespace VisitorPattern
{
    public class Client
    {
        public static void DoVisit(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
