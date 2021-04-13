using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public GameObject player;

    //Checks to make sure user is not in main scene before taking them back to main scene
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && SceneManager.GetActiveScene().name != "TopDownMain")
        {
            SceneManager.LoadScene("TopDownMain");
        }
    }

    //Switch scenes
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hot");
        SceneManager.LoadScene(collision.gameObject.name);
    }

}
