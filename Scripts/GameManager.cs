using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float time;
    [SerializeField]
    private GameObject enemy;

    System.Random rand = new System.Random();

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            Instantiate(enemy, new Vector3(rand.Next(1, 7), rand.Next(-2, 5), 0), Quaternion.identity);
            time = 0;
        }
    }
}
