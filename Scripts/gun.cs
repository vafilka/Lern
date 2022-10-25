using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class gun : MonoBehaviour
{
    public float time;

    public GameObject puka, parant, enemy, parant_en;

    System.Random rand = new System.Random();

    void FixedUpdate()
    {
        time += Time.deltaTime;

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
            Create();
        }
        if(time > 1)
        {
            Random();
            time = 0;
        }
    }

    public void Random()
    {
        var a = Instantiate(enemy);
        a.transform.parent = parant_en.transform;
        a.transform.localScale = new Vector3(1, 1, 1);
        a.transform.localPosition = new Vector3(rand.Next(100,900), rand.Next(-420, 420), 0);
    }

    public void Create()
    {
        var a = Instantiate(puka);
        a.transform.parent = parant.transform;
        a.transform.position = parant.transform.position;
        a.transform.localScale = new Vector3(1,1,1);
   
    }
}
