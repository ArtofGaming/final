using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspectSelect : MonoBehaviour
{
    public static bool activate;
    public GameObject suspectTalkUI;
    
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

    public void Resume()
    {
        suspectTalkUI.SetActive(false);
        activate = false;
    }
    void Pause()
    {
        suspectTalkUI.SetActive(true);
        activate = true;
    }
}
