using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelect : MonoBehaviour
{
    public string[] items = new string[5];
    public static bool collect;
    public GameObject itemShowUI;
   // public GameManager gameManager; // for ponts system
    int x;
    public Image sprite;

    void Start()
    {
      //  gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        sprite = GameObject.Find("Text System").GetComponentInChildren<Image>();
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
        
    }
    void Pause()
    {
        itemShowUI.SetActive(true);
        Debug.Log("Item collected");
      //  gameManager.points += 1;
        collect = true;
        items[x] = sprite.name;
        Debug.Log(items[0]);
        x += 1;

    }
}
