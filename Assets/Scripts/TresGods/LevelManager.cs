using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            GoBackToMainScene();
        }
    }

    private GodNGoddesses[] gods = {GodNGoddesses.Poseidon, GodNGoddesses.Hera, GodNGoddesses.Ares};
    private List<GodNGoddesses> currentGodList = new List<GodNGoddesses>();
    public void CollectPreyee(GodNGoddesses godNGoddesses)
    {
        currentGodList.Add(godNGoddesses);

        if (currentGodList.Count >= 3)
        {
            for(int i = 0; i< currentGodList.Count; i++)
            {
                if (currentGodList[i] != gods[i])
                {
                    break;
                }

                GoBackToMainScene();
            }
            currentGodList.Clear();
        }
    }

    private void GoBackToMainScene()
    {
        GameControl.control.firstQuizSolved = true;
        SceneManager.LoadScene("RocketScene");
    }
}



public enum GodNGoddesses
{
    Poseidon,
    Hera,
    Ares
}
