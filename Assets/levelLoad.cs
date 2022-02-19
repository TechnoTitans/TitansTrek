using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoad : MonoBehaviour
{
    public int iLevelToLoad; 
    public string sLevelToLoad; 

    public bool useINtegertoLoadLevel = false; 

    void Start()
    {
        
    }

     void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider 2D collision)
    {
        GameObject collisionGameObject = collision.GameObject;

        if(collisionGameObject.name == "Player")
        {
            LoadScene(); 
        }

    }
    void LoadScene()
    {
        if(useINtegertoLoadLevel)
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
    }

}
