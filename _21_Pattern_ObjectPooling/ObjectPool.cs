namespace _21_Pattern_ObjectPooling;

// 오브젝트 클래스
public class PoolObject
{
    public bool IsActive { get; set; }

    public PoolObject()
    {
        IsActive = false;
    }
}

// 오브젝트 풀 클래스
public class ObjectPool<T> where T : PoolObject, new()
{
    private readonly List<T> _pool;
    private readonly int _maxSize;

    public ObjectPool(int maxSize = 10)
    {
        _pool = new List<T>(maxSize);
        _maxSize = maxSize;
        for (int i = 0; i < maxSize; i++)
        {
            _pool.Add(new T());
        }
    }
    public T Get(int index)
    {
        return _pool[index];
    }

    public T Use()
    {
        for (int i = 0; i < _pool.Count; i++)
        {
            if (!_pool[i].IsActive)
            {
                _pool[i].IsActive = true;
                return _pool[i];
            }
        }

        return null;    // 모든 오브젝트가 사용중이면 null 반환
    }

    public void Release(T obj)
    {
        if (_pool.Contains(obj))
        {
            obj.IsActive = false;
        }
    }

    public int ActiveCount => _pool.FindAll(obj => obj.IsActive).Count;
    public int InUseCount => _maxSize - ActiveCount;
    public int Capacity => _maxSize;
}