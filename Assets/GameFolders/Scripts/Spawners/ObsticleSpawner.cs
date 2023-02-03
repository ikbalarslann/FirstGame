using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Spawners
{
    public class ObsticleSpawner : MonoBehaviour
    {
        [Range(0f, 3f)]
       [SerializeField] float minSpawnTime = 3f;
        [Range(3f,5f)]
       [SerializeField] float maxSpawntime = 25f;
        [SerializeField] float spawnTime;
        float _currentTime;
        [SerializeField] EnemyController enemy;
        // Start is called before the first frame update
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

       
        
        void Spawn()
        {
            Instantiate(enemy,this.transform);
            
        }
    }
}

