using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float time;

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time> 1)
        {
            Destroy(gameObject);
        }
    }
}
