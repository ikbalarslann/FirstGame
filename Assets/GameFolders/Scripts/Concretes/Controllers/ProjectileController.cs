using FirstGame.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {

            
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(this.gameObject);
            Destroy(collision.GetComponent<Collider>().gameObject);
        }
    }

}
