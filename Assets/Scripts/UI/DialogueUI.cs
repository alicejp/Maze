using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    public Button quitButton;
    public Text content;

    void Start()
    {
        quitButton.onClick.AddListener(OnClick);
    }

    public void UpdateText(string message)
    {
        content.text = message;
    }

    private void OnClick()
    {
        FindObjectOfType<MessageManager>().ShouldShowFirstHint = false;
        FindObjectOfType<MessageManager>().shouldShowTheLetter = false;
    }
}
