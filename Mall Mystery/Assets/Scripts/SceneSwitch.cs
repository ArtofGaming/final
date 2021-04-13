using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && SceneManager.GetActiveScene().name != "TopDownMain")
        {
            SceneManager.LoadScene("TopDownMain");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hot");
        SceneManager.LoadScene(collision.gameObject.name);
    }

}
