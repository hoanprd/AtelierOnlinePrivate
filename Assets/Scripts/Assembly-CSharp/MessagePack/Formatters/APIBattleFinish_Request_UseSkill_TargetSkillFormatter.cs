namespace MessagePack.Formatters
{
	public sealed class APIBattleFinish_Request_UseSkill_TargetSkillFormatter : IMessagePackFormatter<APIBattleFinish.Request.UseSkill.TargetSkill>, IMessagePackFormatter
	{
		public int Serialize(ref byte[] bytes, int offset, APIBattleFinish.Request.UseSkill.TargetSkill value, IFormatterResolver formatterResolver)
		{
			return 0;
		}

		public APIBattleFinish.Request.UseSkill.TargetSkill Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			readSize = default(int);
			return null;
		}
	}
}
