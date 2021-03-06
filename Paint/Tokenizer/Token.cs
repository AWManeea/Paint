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
namespace Paint.Tokenizer
{
	public class Token
	{
		public int Position
		{
			set;
			get;
		}

		public int LineNumber
		{
			set;
			get;
		}

		public TokenType Type
		{
			set;
			get;
		}

		public string Value
		{
			set;
			get;
		}

		public Token()
		{
			this.Position = 0;
			this.LineNumber = 1;
			this.Type = TokenType.Null;
			this.Value = "null";
		}

		public Token(int position, int lineNumber, TokenType type, string value)
		{
			this.Position = position;
			this.LineNumber = lineNumber;
			this.Type = type;
			this.Value = value;
		}

		public override string ToString()
		{
			return this.Value;
		}
	}

	public enum TokenType
	{
		OpeningBracket,
		ClosingBracket,
		OpeningCurlyBracket,
		ClosingCurlyBracket,
		Comma,
		Colon,
		Whitespace,
		String,
		Number,
		True,
		False,
		Null,
	}
}