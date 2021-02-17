using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    int player = 0, college = 30;
    int distance;
    void Start()
    {
        print("Welcome to the game ");
        print("To move front press up arrow ");
        print("To move back press down arrow ");
        print("To move to the left press left arrow ");
        print("To move to the right press right arrow ");
       
    }

    // Update is called once per frame
    void Update()
    {
        distance = college - player;
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("You moved front");
            player++;
          
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("You moved back");
            playe   r--;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            print("You moved to the left");
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            print("You moved to the right ");
        }
        print(player);
        if (player == college)
        {
            print("You have reached your destination");
        }
        else if(player>college)
        {
            print("You have crossed your destination");
            print("Press down arrow ");
        }
        else
        {
            print("Move forward");
        }
    }
}
