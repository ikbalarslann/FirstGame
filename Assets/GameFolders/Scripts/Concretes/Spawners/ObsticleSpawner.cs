using FirstGame.Abstracts.Spawners;
using FirstGame.Controllers;
using FirstGame.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
        
        
     protected override  void Spawn()
        {
            EnemyController obsticlePrefab = ObsticlePool.Instance.Get();
            obsticlePrefab.gameObject.SetActive(true);
            obsticlePrefab.transform.rotation=transform.rotation;
            obsticlePrefab.transform.position=transform.position;
            
            
            
        }
    }
}

