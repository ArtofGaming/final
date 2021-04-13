using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspectSelect : MonoBehaviour
{
    public static bool activate;
    public GameObject suspectTalkUI;
    
    //Checks current state and switches it
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (activate)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    //Remove text UI
    public void Resume()
    {
        suspectTalkUI.SetActive(false);
        activate = false;
    }
    //Shows text UI
    void Pause()
    {
        suspectTalkUI.SetActive(true);
        activate = true;
    }
}
