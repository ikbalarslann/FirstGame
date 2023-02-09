using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace FirstGame.Abstracts.Pools
{
    public abstract class BasePool<T> : MonoBehaviour where T : Component
    {
        [SerializeField] T[] _prefabs;
        [SerializeField] int _countLoop = 5;
        Queue<T> _poolPrefabs= new Queue<T>();

        private void Awake()
        {
            Singleton();
        }
        
        protected abstract void Singleton();
        public T Get()
        {
            if (_poolPrefabs.Count==0)
            {
                GrowPoolPrefabs();
            }
            return _poolPrefabs.Dequeue();
        }
        void GrowPoolPrefabs()
        {
            for (int i = 0; i < _countLoop; i++)
            {
                T newPrefab = Instantiate(_prefabs[Random.Range(0,_prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);

            }
            

        }
       public void Set(T prefab)
        {
            prefab.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(prefab);
        }    
        
            
    }
}

