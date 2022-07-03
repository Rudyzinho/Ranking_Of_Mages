using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectManager : MonoBehaviour
{
    public HealthEnemy healthScript;
    public List<int> burnTikTimers = new List<int>();
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void ApplyBurn(int tiks)
    {
        burnTikTimers.Add(tiks);
        StartCoroutine(Burn());
    }

    public void Damage()
    {
        healthScript.health -= Spells.damage[0];
    }


    IEnumerator Burn()
    {
        while(burnTikTimers.Count > 0)
        {
            for(int i = 0; i < burnTikTimers.Count; i++)
            {
                burnTikTimers[i]--;
            }
            healthScript.health -= 5;
            burnTikTimers.RemoveAll(i => i == 0);
            yield return new WaitForSeconds(0.75f);
        }
    }
}
