using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Object;
    public float spawnRate = 2;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate);
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(Object, transform.position, transform.rotation);
            timer = 0;
        }
        
        
    }
}
