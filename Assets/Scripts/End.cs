using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public GameObject LevelControl;
    public GameObject FadeOut;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Victory Idle");
        LevelControl.GetComponent<LevelDistance>().enabled = false;
    //     SceneManager.LoadScene("EndScene");
        StartCoroutine(EndSequence());
    }


    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("EndScene");
    }



}