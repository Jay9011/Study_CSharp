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

    public ObjectPool(int maxSize = 10)
    {
        for (int i = 0; i < maxSize; i++)
        {
            Insert();
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

        // 모든 오브젝트가 사용중이면 새로운 오브젝트를 생성하고 생성된 오브젝트를 반환
        var obj = Insert();
        obj.IsActive = true;
        return obj;
    }

    public T Insert()
    {
        var obj = new T
        {
            IsActive = false
        };
        _maxSize++;
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

    public int ActiveCount => _pool.FindAll(obj => obj.IsActive).Count;
    public int InUseCount => _maxSize - ActiveCount;
    public int Capacity => _maxSize;
}