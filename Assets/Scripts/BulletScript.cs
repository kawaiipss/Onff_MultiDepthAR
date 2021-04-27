using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(BulletDestroy());
    }

    IEnumerator BulletDestroy()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(Vector3.down * 0.01f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
