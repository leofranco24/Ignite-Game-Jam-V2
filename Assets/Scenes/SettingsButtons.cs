using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class SettingsButtons : MonoBehaviour
{
    public GameObject settingsMenu;
    public Image creditScenes;
    public Sprite[] creditImages;
    public int index = 0;

    public void EnableSettings()
    {
        settingsMenu.SetActive(true);     
    }
    
    public void Play()
    {
        SceneManager.LoadScene("Game/First Scene");
    }

    public void Back()
    {
        settingsMenu.SetActive(false);  
    }

    public void Credits()
    {
        settingsMenu.SetActive(true);  
    }

    public void CreditsToggle()
    {
        index++;
         if (index >= 3)
         {
             index = 0;
         }
        creditScenes.sprite = creditImages[index];
       
    }
    public void QuitGame()
    {
        Application.Quit();
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
