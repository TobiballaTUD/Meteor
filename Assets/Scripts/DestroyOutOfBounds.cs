using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 100;
    private float lowBound = -100;

    void Start()
    {
        
    }

    void Update()
    {
        // Destroy object beyond player view
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowBound)
        {
            Destroy(gameObject);
        }
    }
}
