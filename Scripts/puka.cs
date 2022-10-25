using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puka : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody rb;

    void FixedUpdate()
    {
        rb.velocity = new Vector3(speed, 0);
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

        public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
