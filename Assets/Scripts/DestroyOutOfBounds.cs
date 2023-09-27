using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if object(food) passes the top boundary, destroy it
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // Similarly when an object(Animal) passes the bottom boundary, destroy it and print a debug log saying Game over
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
