namespace GPULang.src.Antlr
{
    public abstract class GPULangASTNode
    {
        protected readonly List<GPULangASTNode> _children = [];
    }

    public class ProgramNode : GPULangASTNode {}

    // TODO: Refactor these constructors with automatic getters and setters as well
    public class AssignmentNode(string lhsID, IConvertible rhsValue) : GPULangASTNode
    {
        protected readonly string _lhsID = lhsID;
        protected readonly IConvertible _rhsValue = rhsValue;
    }

    public class ArrayAssignmentNode(string lhsID, int index, IConvertible rhsValue) : AssignmentNode(lhsID, rhsValue) {
        private readonly int _index = index;
    }

    public class IntLiteralNode(int value) : GPULangASTNode
    {
        private readonly int _value = value;
    }
    
}