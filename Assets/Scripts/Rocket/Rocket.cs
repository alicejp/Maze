using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public float speed = 10f;
    public float horizontalInput;
    public float verticalInput;
    public ParticleSystem crashParticles;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (GameControl.control.firstQuizSolved)
        {
            gameObject.transform.position = new Vector3(28.91f, 0, -20.78f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKey(KeyCode.Z))
        {
            gameObject.transform.position = new Vector3(28.91f, 0, -20.78f);
        }
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
            case "firstQuizCube":
                other.gameObject.GetComponent<MeshRenderer>().material.color = Color.clear;
                other.gameObject.GetComponent<Collider>().enabled = false;
                Destroy(other.gameObject);
                //save up the player's location before we jumps to the TresGodsScene
                GameControl.control.playerPosition = FindObjectOfType<Rocket>().GetComponent<Rigidbody>().position;
                SceneManager.LoadScene("TresGodsScene");
                break;
            default:
                break;
        }
        crashParticles.Play();
    }
}
