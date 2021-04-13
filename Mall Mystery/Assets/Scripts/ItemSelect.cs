using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelect : MonoBehaviour
{
    public static bool collect;
    public GameObject itemShowUI;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (collect)
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
        itemShowUI.SetActive(false);
        Debug.Log("here");
        
    }
    void Pause()
    {
        itemShowUI.SetActive(true);
        Debug.Log("Item collected");
        gameManager.points += 1;
        collect = true;

    }
}
