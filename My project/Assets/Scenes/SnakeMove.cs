using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    //variable 
    private Vector2 direction; //control direction of movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // change direction of snake
        if (Input.GetKeyDown(KeyCode.W))     //When key 'W' is pressed
        {
            direction = Vector2.up;         //go up
        }
        else if (Input.GetKeyDown(KeyCode.S))    //When 'S' Key is pressed
        {
            direction = Vector2.down;      //go down
        }
        else if (Input.GetKeyDown(KeyCode.A))   //When 'A' Key is pressed
        {
            direction = Vector2.left;      //go left
        }
        else if (Input.GetKeyDown(KeyCode.D))  //when 'D' is pressed
        {
            direction = Vector2.right;     //go 
        }
    } 

    // FixedUpdate is called at a fix interval
    void FixedUpdate ()
    {
        this.transform.position = new Vector2(                     //get the position
            Mathf.Round(this.transform.position.x) + direction.x,  //round 
            Mathf.Round(this.transform.position.y) + direction.y
            ); 
    }
    
}
