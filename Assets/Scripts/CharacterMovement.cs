using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float UpDownMoveSpeed;
    public float LeftRigthMoveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            myRigidbody.velocity = Vector2.up * UpDownMoveSpeed;
        }
        
        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            myRigidbody.velocity = Vector2.down * UpDownMoveSpeed;
        }
        
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            myRigidbody.velocity = Vector2.left * LeftRigthMoveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            myRigidbody.velocity = Vector2.right * LeftRigthMoveSpeed;
        }
        
    }
}
