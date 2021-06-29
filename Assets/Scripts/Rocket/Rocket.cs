using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed = 10f;
    public float horizontalInput;
    public float verticalInput;
    public ParticleSystem crashParticles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
    }

    private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag)
        {
            case "hasHint":
                other.gameObject.GetComponent<MeshRenderer>().material.color = Color.clear;
                other.gameObject.GetComponent<Collider>().enabled = false;
                break;
            default:
                break;
        }
        crashParticles.Play();
    }
}
