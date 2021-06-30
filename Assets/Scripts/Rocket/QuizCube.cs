using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameControl.control.firstQuizSolved && tag == "firstQuizCube")
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
