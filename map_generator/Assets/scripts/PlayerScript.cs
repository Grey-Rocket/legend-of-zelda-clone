using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public GridLayout blocker;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per 
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            //Debug.Log();
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - 1.0f, GetComponent<Transform>().position.y);
        }
        else if (Input.GetKeyDown("right"))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x + 1.0f, GetComponent<Transform>().position.y);
        }

        if (Input.GetKeyDown("up"))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1.0f);
        }

        else if (Input.GetKeyDown("down"))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y - 1.0f);
        }
    }

}