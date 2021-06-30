using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public Vector3 playerPosition;
    public bool firstQuizSolved = false;
    private void Awake() {
        var controls = FindObjectsOfType<GameControl>();

        if (controls.Length > 1)
        {
             Destroy(gameObject);
        }
        else{
            DontDestroyOnLoad(gameObject);
            control = this;
        }
    }
}
