using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject GameOverScreen;
    public AudioSource audioSource;
    public AudioClip pageTurn;
    public float volume;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Obstacle")
        {
            Debug.Log("Hit");
            HealthSystem.health--;
            audioSource.PlayOneShot(pageTurn, volume);
            if (HealthSystem.health <=0)
            {
                gameObject.SetActive(false);
                GameOverScreen.SetActive(true);
                
            }
            else
            {

            }
        }

        
    }

    
}
