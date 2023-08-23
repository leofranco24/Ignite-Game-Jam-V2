using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystemManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame() //Used for the "Start" or "Try Again" button
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene(0);

    }
}
