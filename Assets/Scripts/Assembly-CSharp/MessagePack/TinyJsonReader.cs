using System;
using System.IO;
using System.Text;

namespace MessagePack
{
	internal class TinyJsonReader : IDisposable
	{
		private readonly TextReader reader;

		private readonly bool disposeInnerReader;

		private StringBuilder reusableBuilder;

		public TinyJsonToken TokenType { get; private set; }

		public ValueType ValueType { get; private set; }

		public double DoubleValue { get; private set; }

		public long LongValue { get; private set; }

		public ulong ULongValue { get; private set; }

		public decimal DecimalValue { get; private set; }

		public string StringValue { get; private set; }

		public TinyJsonReader(TextReader reader, bool disposeInnerReader = true)
		{
		}

		public bool Read()
		{
			return false;
		}

		public void Dispose()
		{
		}

		private void SkipWhiteSpace()
		{
		}

		private char ReadChar()
		{
			return '\0';
		}

		private static bool IsWordBreak(char c)
		{
			return false;
		}

		private void ReadNextToken()
		{
		}

		private void ReadValue()
		{
		}

		private void ReadNumber()
		{
		}

		private void ReadString()
		{
		}
	}
}
