using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    Text currentText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collision col)
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            currentText = "This is text";
        }
    }
}
