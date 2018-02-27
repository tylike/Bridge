using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
    [Bridge.External]
    [Bridge.Name("System.Object")]
    [Bridge.Cast("{this}.btype === 2")]
    public sealed class MemberListBinding : MemberBinding
    {
        [Bridge.Convention(Bridge.Notation.CamelCase)] //[Field]
        public extern ReadOnlyCollection<ElementInit> Initializers { get; private set; }

        internal extern MemberListBinding();
    }
}