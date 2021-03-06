﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CodeGeneration;
using Microsoft.CodeAnalysis.Completion;
using Microsoft.CodeAnalysis.Completion.Providers;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Editor.Implementation.IntelliSense.Completion.CompletionProviders
{
    internal class MemberInsertionCompletionItem : CompletionItem
    {
        public DeclarationModifiers Modifiers { get; private set; }
        public int Line { get; private set; }
        public SymbolKey SymbolId { get; private set; }
        public SyntaxToken Token { get; private set; }

        public MemberInsertionCompletionItem(
            ICompletionProvider provider,
            string displayText,
            TextSpan filterSpan,
            Func<CancellationToken, Task<ImmutableArray<SymbolDisplayPart>>> descriptionFactory,
            Glyph? glyph,
            DeclarationModifiers modifiers,
            int line,
            SymbolKey symbolId,
            SyntaxToken token)
            : base(provider, displayText, filterSpan, descriptionFactory, glyph)
        {
            this.Modifiers = modifiers;
            this.Line = line;
            this.SymbolId = symbolId;
            this.Token = token;
        }
    }
}
