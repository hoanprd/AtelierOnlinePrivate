using System;
using System.Collections.Generic;

public class LRUCache<K, V> : IDisposable
{
	protected class CacheItem<TypeKI, TypeVI>
	{
		public readonly TypeKI Key;

		public readonly TypeVI Value;

		public CacheItem(TypeKI k, TypeVI v)
		{
		}
	}

	protected readonly uint capacity;

	protected Dictionary<K, CacheItem<K, V>> cacheMap;

	protected List<CacheItem<K, V>> lruList;

	public int Count
	{
		get
		{
			return 0;
		}
	}

	public V[] Values
	{
		get
		{
			return null;
		}
	}

	public K[] Keys
	{
		get
		{
			return null;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public V get_Item(K key)
	{
		return default(V);
	}

	public void set_Item(K key, V value)
	{
	}

	public LRUCache(uint capacity)
	{
	}

	protected LRUCache()
	{
	}

	~LRUCache()
	{
	}

	public void Dispose()
	{
	}

	public void Clear()
	{
	}

	public bool Exist(K key)
	{
		return false;
	}

	public V Get(K key)
	{
		return default(V);
	}

	public void Add(K key, V val)
	{
	}

	private void RemoveFirstItem()
	{
	}

	public void Remove(K key, bool bDestroy = true)
	{
	}

	protected virtual void DisposeItem(CacheItem<K, V> item)
	{
	}

	public string Dump()
	{
		return null;
	}
}
