using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManagerScript;

    void Start()
    {
        scoreManagerScript = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<ScoreManager>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("missile")){
            scoreManagerScript.AddPoint();
        }

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}