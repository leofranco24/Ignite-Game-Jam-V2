using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class SettingsButtons : MonoBehaviour
{
    public GameObject settingsMenu;
    public Image creditScenes;
    public Image instructionScene;
    public Sprite[] creditImages;
    public Sprite[] instructionImages;
    public int index = 0;
    public int instructionIDX = 0;

    public void EnableSettings()
    {
        settingsMenu.SetActive(true);     
    }
    
    public void Play()
    {
        instructionIDX++;
        if (instructionIDX > 3)
        {
            SceneManager.LoadScene("Game/First Scene");
        }
        else
        {
            instructionScene.sprite = instructionImages[instructionIDX];
        }
        
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
    
}
