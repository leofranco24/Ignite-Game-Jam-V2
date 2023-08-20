using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    public GameObject settingsMenu; 
        
    public void EnableSettings()
    {
        settingsMenu.SetActive(true);     
    }
    
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        //gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
