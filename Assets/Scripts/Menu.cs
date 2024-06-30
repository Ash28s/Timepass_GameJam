using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject FadeOut;
    
    public void PlayGame()
    {  
        StartCoroutine(EndSequence());
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        StartCoroutine(BackToMenu());
    }


    IEnumerator EndSequence()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Demo");
    }

    IEnumerator BackToMenu()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }

        
}
