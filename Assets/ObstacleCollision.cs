using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Obstacle")

        {
            Debug.Log("Hit");
            HealthSystem.health--;
            if (HealthSystem.health <=0)
            {
                gameObject.SetActive(false);
            }
            else
            {
            }
        }

        
    }

    
}
