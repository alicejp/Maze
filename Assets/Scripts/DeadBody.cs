using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (tag == "hasHint")
        {
            Debug.Log("hasHint: " + gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            return;
        }
        
        Debug.Log("Do nothing");
    }
}
