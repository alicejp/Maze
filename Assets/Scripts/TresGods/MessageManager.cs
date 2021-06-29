using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    public GameObject hintMessage;
    public bool shouldShowFirstHint = false;
    // Start is called before the first frame update
    void Start()
    {
        hintMessage.SetActive(shouldShowFirstHint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool ShouldShowFirstHint
    {
        set {
            shouldShowFirstHint = value;
            hintMessage.SetActive(value);
        }
    }

    public void showHintMessage()
    {
        ShouldShowFirstHint = true;
    }
}
