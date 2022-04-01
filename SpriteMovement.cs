using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Body;
    public float speed;
    public float horizontal; //x-coordinate on the graph/
    public float veritical; //y-coordinate on the graph
    public float moveLimiter = 0.7f; //limits speed
    void Start()
        //Start sets up the intial values of the script.
    {
        Body = GetComponent<Rigidbody2D>(); //RigidBody handles collisions and physics. In order for the player to move, we need to use the velocity componet in Rigidbody.
    }

    // Update is called once per frame
    void Update()
        //Updates the code. Update acts almost like a while loop where it will continuously update when conditions are met
    {
       horizontal = Input.GetAxisRaw("Horizontal"); //Horizontal is defined within the input manager already so we don't need to worry about creating inputs
        veritical = Input.GetAxisRaw("Vertical"); // Same with horizontal
        
    }
     void FixedUpdate()
    {
        if(horizontal != 0 && veritical != 0) //Checks if the player is going in a horizontal direction
        {
            horizontal *= moveLimiter; //divides the horizontal by 7 to lower the horizontal value
            veritical *= moveLimiter; 
        }
        Body.velocity = new Vector2(horizontal * speed, veritical * speed); //We set velocity to a new vector2, setting the x-value equal to horizontal * speed.
    }
    
}//velocity = Hoe fast is the player going on either the x or y axis. It is a pair(more specifically, a vector2 in Unity).
