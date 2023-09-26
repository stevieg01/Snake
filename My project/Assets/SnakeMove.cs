using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    //variable 
    private Vector2 direction; //control direction of movement

    List<Transform> segments;              //contrp; direction of movement
    public Transform bodyPrefab;           //variable to store the body 

    // Start is called before the first frame update
    void Start()
    {
        segments = new List<Transform>();  //create a new list
        segments.Add(transform);           //add the head of the snake to the lis
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
    void FixedUpdate()
    {
        this.transform.position = new Vector2(                     //get the position
            Mathf.Round(this.transform.position.x) + direction.x,  //round 
            Mathf.Round(this.transform.position.y) + direction.y
            );
    }
    //Function to make the snake grow
    void Grow()
    {
        Transform segment = Instantiate(this.bodyPrefab);            //get the position
        segment.position = segments[segments.Count - 1].position;   //round the number ass value to X
        segments.Add(segment);                                      //round the number ass value to Y
    }

    //Function for collisio
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "food")
        {
            Grow();
        }
    }
}