/*
 * Tuwaiq .NET Bootcamp | Paint
 * 
 * Team Members
 * 
 * Abdulrahman Bin Maneea
 * Younes Alturkey
 * Anas Alhmoud
 * Faisal Alsagri
 * 
 */
using System;

namespace Paint.Tokenizer
{
    public class Tokenizer
    {
        public Input input;
        public Tokenizable[] handlers;
        public Tokenizer(Input input, Tokenizable[] handlers)
        {
            this.input = input;
            this.handlers = handlers;
        }

        public Token tokenize()
        {
            if (!this.input.hasMore())
                return null;
            foreach (var handler in this.handlers)
                if (handler.tokenizable(this.input))
                    return handler.tokenize(this.input);
            throw new Exception($@"Unexpected token: ""{this.input.peek()}"" at position {this.input.Position} (Line: {this.input.LineNumber}, column: {this.input.Column})");
        }
    }
}