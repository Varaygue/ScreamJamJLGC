using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroToHub : MonoBehaviour
{
    private void OnTriggerEnter(Collider ToHub)
    {
        SceneManager.LoadScene("Level_HUB_Blocking");
    }
}
