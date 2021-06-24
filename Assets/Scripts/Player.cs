using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        if (Mathf.Abs(Input.GetAxis("Horizontal"))> Mathf.Epsilon)
        {
            MovePlayerHorizontally();
        }
        else if (Mathf.Abs(Input.GetAxis("Vertical")) > Mathf.Epsilon)
        {
            MovePlayerVertically(); 
        }

    }

    private void MovePlayerHorizontally()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal"), 0,0);
    }

    private void MovePlayerVertically()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, Input.GetAxis("Vertical"));
    }
}
