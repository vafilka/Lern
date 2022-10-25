using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class gun : MonoBehaviour
{
    [SerializeField]
    private GameObject puka, parant;

    System.Random rand = new System.Random();

    void FixedUpdate()
    {
       

        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(transform.position, new Vector3(0, 0, 0.02f), 500f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(transform.position, new Vector3(0, 0, -0.02f), 500f * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(puka, parant.transform.position, Quaternion.identity, parant.transform);
        }
      
    }
}
