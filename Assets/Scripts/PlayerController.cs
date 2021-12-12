using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float horizontalInput;
    public float speed = 80.0f;
    public float xRange = 88.0f;
    public bool isInSpace = true;
    public bool gameOver = false;

    //Missile
    public GameObject projectilePrefab;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch missile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("space"))
            {
                isInSpace = true;
            }

            else if (collision.gameObject.CompareTag("meteor"))
            {
                Debug.Log("Game Over");
                gameOver = true;
            }
        }
}
