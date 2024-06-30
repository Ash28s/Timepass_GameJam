using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject LiveCoin;
    public GameObject LiveDis;
    public GameObject EndScreen;
    public GameObject FadeOut;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        LiveCoin.SetActive(false);
        LiveDis.SetActive(false);
        EndScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
