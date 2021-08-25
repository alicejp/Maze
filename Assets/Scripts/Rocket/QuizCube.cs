using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCube : MonoBehaviour
{
    void Start()
    {
        if (GameControl.control.firstQuizSolved && tag == "firstQuizCube")
        {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        
    }
}
