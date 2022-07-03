using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulettVel = 10;

    void Update()
    {
        transform.Translate(Vector2.up * bulettVel * Time.deltaTime);
        StartCoroutine(destroyBullet());
    }

    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }

}
