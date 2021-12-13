using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManagerScript;
    private GameController gameController;
    public bool isGameActive;

    void Start()
    {
        gameController = GameObject.Find("Game Controller").GetComponent<GameController>();
        scoreManagerScript = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<ScoreManager>();
        isGameActive = true;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("missile")) {
            scoreManagerScript.AddScore();
        }
        else {
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameController.GameOver();
            isGameActive = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("space"))
        {
        }

        else if (collision.gameObject.CompareTag("meteor"))
        {

        }
    }
}