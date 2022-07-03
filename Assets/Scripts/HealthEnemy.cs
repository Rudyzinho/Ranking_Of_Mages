using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public float health;
    public float maxHealth;
    

    void Start()
    {
        

        health = maxHealth;
        
    }
    void Update()
    {
        
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void DamageInLife(float damage)
    {
        health -= damage;
    }




}
