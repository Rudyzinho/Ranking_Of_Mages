using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{

    public float speed = 4;

    public void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<EnemyBehaviour>();
        if(enemy)
        {
            enemy.TakeHit(1);
            
        }
        if(!other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
       
    }
    

}
