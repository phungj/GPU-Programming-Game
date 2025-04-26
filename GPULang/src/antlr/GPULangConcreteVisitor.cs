using JetBrains.Annotations;

using GPULang.src.Antlr.Generated;

namespace GPULang.src.Antlr
{
    public class GPULangConcreteVisitor : GPULangBaseVisitor<GPULangASTNode>
    {
        public override GPULangASTNode VisitProgram([NotNull] GPULangParser.ProgramContext context)
        {
            throw new NotImplementedException();
        }

        public override GPULangASTNode VisitStatement([NotNull] GPULangParser.StatementContext context)
        {
            throw new NotImplementedException();
        }

        public override GPULangASTNode VisitAssignment([NotNull] GPULangParser.AssignmentContext context)
        {
            throw new NotImplementedException();
        }

        public override GPULangASTNode VisitSubscript([NotNull] GPULangParser.SubscriptContext context)
        {
            throw new NotImplementedException();
        }
    }
}