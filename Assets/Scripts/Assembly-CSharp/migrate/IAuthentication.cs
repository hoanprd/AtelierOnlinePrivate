using System;

namespace migrate
{
	internal interface IAuthentication
	{
		string ID { get; }

		void Init();

		void Authenticate(Action<bool, string> action);

		void Failed(Action callback);
	}
}
