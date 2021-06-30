using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    public GameObject hintMessage;
    public bool shouldShowFirstHint = false;
    public bool shouldShowTheLetter = false;
    // Start is called before the first frame update
    void Start()
    {
        hintMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool ShouldShowFirstHint
    {
        set {
            shouldShowFirstHint = value;
            hintMessage.GetComponent<DialogueUI>().UpdateText(GetString());
            hintMessage.SetActive(value);
        }
    }

    public bool ShouldShowTheLetter
    {
        set {
            shouldShowTheLetter = value;
            hintMessage.GetComponent<DialogueUI>().UpdateText(GetString());
            hintMessage.SetActive(value);
        }
    }

    public void showHintMessage()
    {
        ShouldShowFirstHint = true;
    }

    public string GetString()
    {
        if (shouldShowFirstHint)
        {
            return "Get closer to them. You should be able to find something. This is the key for you to get out here.";
        }else if (shouldShowTheLetter)
        {
            return "You must pray for the god and the goddesses in the correct order then the door will be open.";
        }
        return "";
    }
}
