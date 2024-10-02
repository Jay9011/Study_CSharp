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
    private readonly List<T> _pool = new List<T>();
    private int _maxSize;

    public ObjectPool(int initSize = 5, int maxSize = 10)
    {
        if (initSize > maxSize)
            maxSize = initSize;
        _maxSize = maxSize;

        for (int i = 0; i < initSize; i++)
        {
            Insert();
        }
    }
    public T Get(int index)
    {
        if (index < 0 || index >= _pool.Count)
            return null;

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

        // 모든 오브젝트가 사용중이면 새로운 오브젝트를 생성하고 생성된 오브젝트를 반환
        var obj = Insert(true);
        
        return obj;
    }

    public T Insert(bool bUse = false)
    {
        if (_maxSize <= _pool.Count)
            return null;

        var obj = new T
        {
            IsActive = bUse
        };
        _pool.Add(obj);

        return obj;
    }

    public void Release(T obj)
    {
        if (_pool.Contains(obj))
        {
            obj.IsActive = false;
        }
    }

    public int Count => _pool.Count;
    public int Capacity => _maxSize;
    public int ActiveCount => _pool.FindAll(obj => obj.IsActive).Count;
    public int UsableCount => Count - ActiveCount;
}