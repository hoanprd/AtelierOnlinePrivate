using System.Collections.Generic;

public static class ListHelper
{
	public static bool IsEmpty<Type>(this ICollection<Type> list)
	{
		return false;
	}

	public static Type Last<Type>(this List<Type> list)
	{
		return default(Type);
	}

	public static void Enqueue<Type>(this List<Type> list, Type obj)
	{
	}

	public static Type Dequeue<Type>(this List<Type> list)
	{
		return default(Type);
	}

	public static void Push<Type>(this List<Type> list, Type obj)
	{
	}

	public static Type Pop<Type>(this List<Type> list)
	{
		return default(Type);
	}
}
