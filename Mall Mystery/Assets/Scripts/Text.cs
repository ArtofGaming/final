using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public TextAsset csvFile;
    private char lineSeperator = '\n';
    private char fieldSeperator = ',';
    public Text contentArea;
    // Start is called before the first frame update
    void Start()
    {
        readLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void readLine()
    {
        string[] dialogue = csvFile.text.Split(lineSeperator);
        foreach (string talk in dialogue)
        {
            string[] text = csvFile.text.Split(fieldSeperator);
            Debug.Log(text);
            foreach (string word in text)
            {
                contentArea.text += word + '\t';
            }
        }
    }
}
