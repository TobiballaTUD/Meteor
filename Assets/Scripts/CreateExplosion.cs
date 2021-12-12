using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateExplosion : MonoBehaviour
{
    private ScoreManager scoreManagerScript;
    public ParticleSystem explosionParticle;

    void Start()
    {
        scoreManagerScript = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<ScoreManager>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("meteor"))
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}