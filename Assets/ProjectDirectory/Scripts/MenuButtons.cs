using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public int waitTime = 2;
    public Animator menuAnim;
    public GameObject menuPanel;
    public GameObject creditsPanel;
    public AudioSource audioSource;
    public AudioClip playAudio;
    public AudioClip creditsAudio;
    public AudioClip quitAudio;
    
    public void gameLoad()
    {
        audioSource.PlayOneShot(playAudio);
        StartCoroutine(loadGame());
    }

    public void showCredits()
    {
        audioSource.PlayOneShot(creditsAudio);
        creditsPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void leaveCredits()
    {
        audioSource.PlayOneShot(creditsAudio);
        creditsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void Exit()
    {   
        audioSource.PlayOneShot(quitAudio);
        Application.Quit();
    }

    IEnumerator loadGame()
    {
        menuAnim.SetTrigger("gamelaunch");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Level_Intro_Blocking");
    }
}
