using System.Collections;

namespace GPULang.src.Antlr
{
    public abstract class GPULangASTNode
    {
        protected readonly List<GPULangASTNode> _children = [];
    }

    public class ProgramNode : GPULangASTNode {}

    // TODO: Refactor these constructors with automatic getters and setters as well
    public class AssignmentNode(string lhsID, string rhsID) : GPULangASTNode
    {
        private readonly string _lhsID = lhsID;
        private readonly string _rhsID = rhsID;
    }

    public class IntLiteralNode(int value) : GPULangASTNode
    {
        private readonly 
    }
    
}