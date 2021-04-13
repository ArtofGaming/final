using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsToPoints : MonoBehaviour
{
    public Dropdown suspect;
    public Dropdown weapon;
    string suspectSelected;
    string itemSelected;
    //public ItemSelect ItemSelect;
    public Text winText;
   
    // Start is called before the first frame update
    void Start()
    {
        //ItemSelect = GameObject.Find("Text System").GetComponent<ItemSelect>();
    }

    //Check to see if valid suspect item pair has been selected
    void Update()
    {
        suspectSelected = suspect.GetComponent<Dropdown>().captionText.text;
        itemSelected = weapon.GetComponent<Dropdown>().captionText.text;

        if (itemSelected == "hanger" && suspectSelected == "Jared")
        {
            winText.text = "You win!!!!!!!!!";
        }
        /*foreach (string item in ItemSelect.items)
        {
            if (item == "hanger" && suspectSelected == "Jared")
            {
                winText.text = "You win!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            }
        }*/
    }
}
