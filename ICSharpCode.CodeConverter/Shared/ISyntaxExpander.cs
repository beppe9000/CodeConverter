﻿using Microsoft.CodeAnalysis;

namespace ICSharpCode.CodeConverter.Shared
{
    internal interface ISyntaxExpander
    {
        bool ShouldExpandWithinNode(SyntaxNode node, SyntaxNode root, SemanticModel semanticModel);
        bool ShouldExpandNode(SyntaxNode node, SyntaxNode root, SemanticModel semanticModel);
        SyntaxNode TryExpandNode(SyntaxNode node, SyntaxNode root, SemanticModel semanticModel, Workspace workspace);
    }
}