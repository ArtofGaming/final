using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class Text : MonoBehaviour
{
    public TextAsset file;
    int lineStart;
    public Text texts;
    char dialogueCutter = '\n';
    char nameCutter = ',';
    // Start is called before the first frame update
    void Start()
    {
        readData(lineStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void readData(int lineNumber)
    {
        string[] lines = file.text.Split(dialogueCutter);
        foreach (string line in lines)
        {
            string[] squares = file.text.Split(nameCutter);
            foreach (string square in squares)
            {
                
            }
        }
    }
}
