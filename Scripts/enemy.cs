using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float time;

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time> 1)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("dead"))
        {
            Destroy(gameObject);
        }
    }
}
