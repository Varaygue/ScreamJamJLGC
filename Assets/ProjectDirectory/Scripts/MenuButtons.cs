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
    
    public void gameLoad()
    {
        StartCoroutine(loadGame());
    }

    public void showCredits()
    {
        creditsPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void leaveCredits()
    {
        creditsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void Exit()
    {   
        Application.Quit();
    }

    IEnumerator loadGame()
    {
        menuAnim.SetTrigger("gamelaunch");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Level_Intro_Blocking");
    }
}
