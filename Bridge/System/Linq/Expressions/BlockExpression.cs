using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
    [Bridge.External]
    [Bridge.Name("System.Object")]
    [Bridge.Cast("{this}.ntype === 47")]
    public sealed class BlockExpression : Expression
    {
        [Bridge.Convention(Bridge.Notation.CamelCase)] //[Field]
        public extern ReadOnlyCollection<Expression> Expressions { get; private set; }

        public extern ReadOnlyCollection<ParameterExpression> Variables
        {
            [Bridge.Template("({this}.variables || Bridge.toList([]))")] get;
            private set;
        }

        public extern Expression Result
        {
            [Bridge.Template("{this}.expressions.getItem({this}.expressions.Count - 1)")]
            get;
            private set;
        }

        internal extern BlockExpression();
    }
}