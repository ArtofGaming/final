using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour
{
    public TextAsset file1;
    public Text dialogue;
    char lineCutter = ',';
    char squareCutter = '\n';
    public int x = 0;
    public int end = 0;
    bool nextLine = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        readData();
        if (Input.GetButtonUp("Fire1") && x < end)
        {
            x += 1;
        }
    }
    void readData ()
    {
        // Split the csv based based on the line
        string[] lines = file1.text.Split(new char[] { '\n' });
        if (end > lines.Length - 1)
        {
            end = lines.Length - 1;
        }
        for (int i = 0; i < end; i++)
        {
            //iterate through every line to show the name-value pair
            string[] squares = file1.text.Split(squareCutter);
            foreach (string square in squares)
            {
                dialogue.text = squares[x];
                //dialogue.text += squares[x + 1];
            }
            dialogue.text += '\n';
        }
    }
    
}
