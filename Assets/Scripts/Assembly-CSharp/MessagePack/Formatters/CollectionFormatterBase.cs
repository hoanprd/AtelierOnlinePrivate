using System.Collections.Generic;

namespace MessagePack.Formatters
{
	public abstract class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : IMessagePackFormatter<TCollection>, IMessagePackFormatter where TEnumerator : IEnumerator<TElement> where TCollection : IEnumerable<TElement>
	{
		public int Serialize(ref byte[] bytes, int offset, TCollection value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public TCollection Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return default(TCollection);
		}

		protected virtual int? GetCount(TCollection sequence)
		{
			return null;
		}

		protected abstract TEnumerator GetSourceEnumerator(TCollection source);

		protected abstract TIntermediate Create(int count);

		protected abstract void Add(TIntermediate collection, int index, TElement value);

		protected abstract TCollection Complete(TIntermediate intermediateCollection);
	}
	public abstract class CollectionFormatterBase<TElement, TIntermediate, TCollection> : CollectionFormatterBase<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : IEnumerable<TElement>
	{
		protected override IEnumerator<TElement> GetSourceEnumerator(TCollection source)
		{
			return null;
		}
	}
	public abstract class CollectionFormatterBase<TElement, TCollection> : CollectionFormatterBase<TElement, TCollection, TCollection> where TCollection : IEnumerable<TElement>
	{
		protected sealed override TCollection Complete(TCollection intermediateCollection)
		{
			return default(TCollection);
		}
	}
}
