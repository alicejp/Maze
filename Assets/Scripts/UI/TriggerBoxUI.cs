using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxUI : MonoBehaviour
{
    public ParticleSystem crashParticles;
    private void OnCollisionEnter(Collision other) {
        switch (gameObject.tag)
        {
            case "Poseidon":
                 FindObjectOfType<LevelManager>().CollectPreyee(GodNGoddesses.Poseidon);
                break;
            case "Hera":
                FindObjectOfType<LevelManager>().CollectPreyee(GodNGoddesses.Hera);
                break;
            case "Ares":
                FindObjectOfType<LevelManager>().CollectPreyee(GodNGoddesses.Ares);
                break;
            default:
                break;
        }
        crashParticles.Play();
        
    }
}
