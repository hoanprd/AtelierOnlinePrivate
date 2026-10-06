namespace MessagePack.Formatters
{
	public sealed class EquipData_AccessoryFormatter : IMessagePackFormatter<EquipData.Accessory>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, EquipData.Accessory value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public EquipData.Accessory Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
