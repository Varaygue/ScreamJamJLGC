using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpot : MonoBehaviour
{
    public FirstPersonController scriptPlayer;
    public GameObject hideText, stopHideText;
    public GameObject normalPlayer, hidingPlayer;
    public MonsterBehavior scriptMonster;
    public Transform monsterTransform;
    bool interactable, hiding;
    public float loseDistance;

    void Start()
    {
        interactable = false;
        hiding = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                hideText.SetActive(false);
                hidingPlayer.SetActive(true);
                float distance = Vector3.Distance(monsterTransform.position, normalPlayer.transform.position);
                if(distance > loseDistance)
                {
                    if(scriptMonster.chasing == true)
                    {
                        scriptMonster.stopChase();
                    }
                }
                stopHideText.SetActive(true);
                hiding = true;
                normalPlayer.SetActive(false);
                interactable = false;
                scriptPlayer.isHiding = true;
            }
        }
        if(hiding == true)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                stopHideText.SetActive(false);
                normalPlayer.SetActive(true);
                hidingPlayer.SetActive(false);
                hiding = false;
            }
        }
    }
}