using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] Pool _projectile;
    public static Pool Instance { get; private set; }
    Queue<Pool> Projectiles = new Queue<Pool>();

    private void Start()
    {
        if (Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public Pool Get()
    {
        if (Projectiles.Count==0)
        {
            GrowPool(1);
        }
        return Projectiles.Dequeue();
    }

    private  void GrowPool( int count)
    {
        for (int i = 0; i < count; i++)
        {
            Pool pool = Instantiate(_projectile);
            pool.gameObject.SetActive(false);
            Projectiles.Enqueue(pool);

        }
    }
    public void Set(Pool mermi)
    {
        
        mermi.gameObject.SetActive(false);
        Projectiles.Enqueue(mermi);
        

    }
}
