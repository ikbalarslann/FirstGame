using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Abstracts.Spawners
{
    public abstract class BaseSpawner :MonoBehaviour

    {
        [Range(0f, 3f)]
        [SerializeField] float minSpawnTime = 3f;
        [Range(3f, 5f)]
        [SerializeField] float maxSpawntime = 5f;
        [SerializeField] float spawnTime;
        float _currentTime;
        
        void Start()
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawntime);
        }
        void Update()
        {

            NewSpawnMultiple();


        }
        private void NewSpawnMultiple()
        {


            _currentTime += Time.deltaTime;

            if (_currentTime >= spawnTime)
            {
                spawnTime = Random.Range(minSpawnTime, maxSpawntime);
                Spawn();
                _currentTime = 0f;
            }

        }



       protected abstract void Spawn();
        
    }
}

