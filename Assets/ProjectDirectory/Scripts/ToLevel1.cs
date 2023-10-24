using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider ToLevel1)
    {
        SceneManager.LoadScene("Level_1_Blocking");
    }
}
