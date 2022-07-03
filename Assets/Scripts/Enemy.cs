using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     public float life = 50;
     
     void Start()
     {
 
     }

     void Update()
     {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
     }
        
    public void DamageInLife()
    {
        life -= 10;
    }

}
