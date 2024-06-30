using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject DisDisplay;
    public GameObject DisEndDisplay;
    public int DisRun;
    public bool AddingDis = false;
    public float DisDelay = 0.35f;
    void Update()
    {
        if(AddingDis == false){
            AddingDis = true;
            StartCoroutine(addingDis());
        }
    }

    IEnumerator addingDis()
    {
        DisRun += 1;
        DisDisplay.GetComponent<Text>().text = "" + DisRun;
        DisEndDisplay.GetComponent<Text>().text = "" + DisRun;
        yield return new WaitForSeconds(DisDelay);
        AddingDis = false;
    }
}
