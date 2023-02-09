using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    
    void Ates()
    {
        Pool newObject = Pool.Instance.Get();
        newObject.transform.position= transform.position;
        newObject.transform.rotation = transform.rotation;  
        newObject.gameObject.SetActive(true);
        
    }
}
