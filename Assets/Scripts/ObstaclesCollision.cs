using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource CrashThud;
    public GameObject MainCamera; 
    public GameObject LevelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        LevelControl.GetComponent<LevelDistance>().enabled = false;
        CrashThud.Play();
        MainCamera.GetComponent<Animator>().enabled = true;
        LevelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}


