using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBody : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (tag == "hasHint")
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            return;
        }
    }
}
