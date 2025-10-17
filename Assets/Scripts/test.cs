using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1.0f;
    public Vector3 pointA;
    public Vector3 pointB;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);

        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
