using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int points = 0;

    void Start()
    {

    }


    private void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 100, 20), "Points: " + points);
    }
}
