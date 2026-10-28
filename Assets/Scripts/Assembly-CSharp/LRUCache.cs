using System;
using System.Collections.Generic;
using System.Text;

public class LRUCache<K, V> : IDisposable
{
	protected class CacheItem<TypeKI, TypeVI>
	{
		public readonly TypeKI Key;

		public readonly TypeVI Value;

		public CacheItem(TypeKI k, TypeVI v)
		{
			Key = k;
			Value = v;
		}
	}

	protected readonly uint capacity;

	protected Dictionary<K, CacheItem<K, V>> cacheMap;

	protected List<CacheItem<K, V>> lruList;

	public int Count
	{
		get
		{
			return cacheMap != null ? cacheMap.Count : 0;
		}
	}

	public V[] Values
	{
		get
		{
			if (lruList == null)
			{
				return new V[0];
			}
			V[] arr = new V[lruList.Count];
			for (int i = 0; i < lruList.Count; i++)
			{
				arr[i] = lruList[i].Value;
			}
			return arr;
		}
	}

	public K[] Keys
	{
		get
		{
			if (lruList == null)
			{
				return new K[0];
			}
			K[] arr = new K[lruList.Count];
			for (int i = 0; i < lruList.Count; i++)
			{
				arr[i] = lruList[i].Key;
			}
			return arr;
		}
	}

	public V this[K key]
	{
		get
		{
			return Get(key);
		}
		set
		{
			Add(key, value);
		}
	}

	public LRUCache(uint capacity)
	{
		this.capacity = capacity;
		cacheMap = new Dictionary<K, CacheItem<K, V>>();
		lruList = new List<CacheItem<K, V>>();
	}

	protected LRUCache()
		: this(64u)
	{
	}

	~LRUCache()
	{
		Dispose();
	}

	public void Dispose()
	{
		Clear();
		GC.SuppressFinalize(this);
	}

	public void Clear()
	{
		if (lruList != null)
		{
			for (int i = 0; i < lruList.Count; i++)
			{
				DisposeItem(lruList[i]);
			}
			lruList.Clear();
		}
		if (cacheMap != null)
		{
			cacheMap.Clear();
		}
	}

	public bool Exist(K key)
	{
		return key != null && cacheMap != null && cacheMap.ContainsKey(key);
	}

	public V Get(K key)
	{
		if (key != null && cacheMap != null && cacheMap.TryGetValue(key, out CacheItem<K, V> item))
		{
			lruList.Remove(item);
			lruList.Add(item);
			return item.Value;
		}
		return default(V);
	}

	public void Add(K key, V val)
	{
		if (key == null)
		{
			return;
		}
		if (cacheMap.TryGetValue(key, out CacheItem<K, V> existing))
		{
			lruList.Remove(existing);
			cacheMap.Remove(key);
		}
		else if (capacity > 0 && cacheMap.Count >= capacity)
		{
			RemoveFirstItem();
		}
		CacheItem<K, V> cacheItem = new CacheItem<K, V>(key, val);
		lruList.Add(cacheItem);
		cacheMap.Add(key, cacheItem);
	}

	private void RemoveFirstItem()
	{
		if (lruList != null && lruList.Count > 0)
		{
			CacheItem<K, V> first = lruList[0];
			lruList.RemoveAt(0);
			cacheMap.Remove(first.Key);
			DisposeItem(first);
		}
	}

	public void Remove(K key, bool bDestroy = true)
	{
		if (key != null && cacheMap != null && cacheMap.TryGetValue(key, out CacheItem<K, V> item))
		{
			lruList.Remove(item);
			cacheMap.Remove(key);
			if (bDestroy)
			{
				DisposeItem(item);
			}
		}
	}

	protected virtual void DisposeItem(CacheItem<K, V> item)
	{
	}

	public string Dump()
	{
		StringBuilder sb = new StringBuilder();
		if (lruList != null)
		{
			for (int i = 0; i < lruList.Count; i++)
			{
				sb.AppendLine(lruList[i].Key?.ToString());
			}
		}
		return sb.ToString();
	}
}
