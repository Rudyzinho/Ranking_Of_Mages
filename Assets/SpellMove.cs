using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMove : MonoBehaviour
{
    public float Vel;

    float time = 10f;



    void Start()
    {
        if (this.gameObject.CompareTag("Ball"))
        {
            time = 4f;
            StartCoroutine(destroyBullet());
        }
        if (this.gameObject.CompareTag("Fire"))
        {
            time = 3f;
            StartCoroutine(destroyBullet());
        }


    }

    void Update()
    {
        transform.Translate(Vector2.up * Vel * Time.deltaTime);

        //StartCoroutine(destroyBullet());
    }

    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}
