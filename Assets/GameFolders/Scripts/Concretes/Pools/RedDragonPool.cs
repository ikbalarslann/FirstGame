using FirstGame.Abstracts.Pools;
using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Pools
{
    public class RedDragonPool : BasePool<RedDragonController>
    {
        public static RedDragonPool Instance { get; private set; }
        protected override void Singleton()
        {
            if (Instance != null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
        }
    }
}

