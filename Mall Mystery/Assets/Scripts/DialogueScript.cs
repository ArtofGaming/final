using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour
{
    public TextAsset file;
    Text dialogue;
    char lineCutter = '\n';
    char squareCutter = ',';
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        dialogue.text = "Hi";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void readData ()
    {
        string[] lines = file.text.Split(lineCutter);
        foreach(string line in lines)
        {
            string[] squares = file.text.Split(squareCutter);
            foreach(string square in squares)
            {
                dialogue.text += squares[x] += "t";
                x += 1;
            }
        }
    }
}
