// Copyright (c) 2019 - Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
namespace Tomlyn.Syntax
{
    public sealed class InvalidSyntaxToken : SyntaxToken
    {
        public TokenKind InvalidKind { get; set; }
    }
}