using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardyA : MonoBehaviour
{
    public float xSpeed = 0.01f;
    public float xMin;
    public float xMax;

    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = DoMove();

        if (newPosition.x >= xMax)
        {
            direction = -1;
            newPosition.x = xMax;
        }

        else if (newPosition.x <= xMin)
        {
            direction = 1;
            newPosition.x = xMin;
        }

        transform.position = newPosition;
    }

    protected Vector3 DoMove()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x = currentPosition.x + direction * xSpeed * Time.deltaTime;
        return currentPosition;
    }
}