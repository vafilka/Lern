using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puka : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        transform.localPosition += new Vector3(speed * Time.deltaTime,0 ,0);
   
    }
}
