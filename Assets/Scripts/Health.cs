using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float health;
    [SerializeField]
    private float maxHealth = 100f;

    public HealthbarBehaviour Healthbar;

    private void Start()
    {
        health = maxHealth;
        Healthbar.SetHealth(health, maxHealth);
        
        
    }

    public void UpdateHealth(float mod)
    {
        health += mod;
        Healthbar.SetHealth(health, maxHealth);

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if(health <= 0f)
        {
            health = 0f;
            Destroy(gameObject);
            SceneManager.LoadScene("Lobby");
        }
    }

}
