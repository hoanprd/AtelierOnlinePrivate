namespace MessagePack.Formatters
{
	public sealed class APIBattleFinish_Request_UseSkillFormatter : IMessagePackFormatter<APIBattleFinish.Request.UseSkill>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleFinish.Request.UseSkill value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleFinish.Request.UseSkill Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
