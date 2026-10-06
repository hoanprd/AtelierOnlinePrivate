namespace MessagePack.Formatters
{
	public sealed class BattleFinish_SkillEffectFormatter : IMessagePackFormatter<BattleFinish.SkillEffect>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, BattleFinish.SkillEffect value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public BattleFinish.SkillEffect Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
