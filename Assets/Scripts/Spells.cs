using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spells : MonoBehaviour
{
    public Transform[] spell;


    public Transform pivot;

    public int mageType;

    public static float[] damage = new float[100];

    [InspectorName("Cooldown")]
    public float[] cooldownTime = new float[100];

    float[] nextFireTime = new float[100];

    public CharacterC characterC;


    void Start()
    {
      
    }

    void Update()
    {

        

            //this.gameObject.transform.rotation;

            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
            transform.up = direction;

            switch (mageType)
            {
                case 1:
                    FireBall();
                    //Fire();
                    break;
                case 2:
                    Debug.Log("EM DESENVOLVIMENTO...");
                    break;
            }

    }


    //Fire Mage
    public void FireBall()
    {
  
        damage[0] = 5f;

        if (Time.time > nextFireTime[0])
        {
            if (Input.GetMouseButton(0))
            {
                
                Instantiate(spell[0], pivot.transform.position, this.gameObject.transform.rotation);
                nextFireTime[0] = Time.time + cooldownTime[0];
                //Debug.Log("NextTime :" + nextFireTime);
                characterC.anim.SetTrigger("Attack");
            }
        }
        

    }

    public void Fire()
    {
        damage[1] = 2f;

        if (Time.time > nextFireTime[1])
        {
            if (Input.GetMouseButton(1))
            {
  
                Instantiate(spell[1], pivot.transform.position, this.gameObject.transform.rotation);
                nextFireTime[1] = Time.time + cooldownTime[1];
                //Debug.Log("NextTime :" + nextFireTime);
                characterC.anim.SetTrigger("Attack");

            }
        }
        
    }

}