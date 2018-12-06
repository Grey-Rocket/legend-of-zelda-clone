using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerScript : MonoBehaviour
{
    public Tilemap test;

    public GridLayout blocker;

    // Use this for initialization
    void Start()
    {

        //gets cell position
        /*
         Vector3Int cellPosition = blocker.WorldToCell(
                GetComponent<Transform>().position);
           */

        //Debug.Log(test.GetTile(cellPosition));
    }

    // Update is called once per 
    void Update()
    {
        //gets cell position
        Vector3Int cellPosition = blocker.WorldToCell(
                GetComponent<Transform>().position);

        //Debug.Log(test.GetTile(cellPosition));
        if (Input.GetKeyDown("left") && validPosition("left", cellPosition))
        {
            //Debug.Log();
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - 1.0f, GetComponent<Transform>().position.y);
        }
        else if (Input.GetKeyDown("right") && validPosition("right", cellPosition))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x + 1.0f, GetComponent<Transform>().position.y);
        }

        if (Input.GetKeyDown("up") && validPosition("up", cellPosition))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 1.0f);
        }

        else if (Input.GetKeyDown("down") && validPosition("down", cellPosition))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y - 1.0f);
        }
    }

    private bool validPosition(string direction, Vector3Int cellPosition)
    {

        if (direction.Equals("left"))
        {
            if (test.GetTile(new Vector3Int(cellPosition.x - 1, cellPosition.y, cellPosition.z)) != null)
                return false;
        }

        else if (direction.Equals("right"))
        {
            if (test.GetTile(new Vector3Int(cellPosition.x + 1, cellPosition.y, cellPosition.z)) != null)
                return false;
        }

        else if (direction.Equals("up"))
        {
            if (test.GetTile(new Vector3Int(cellPosition.x, cellPosition.y + 1, cellPosition.z)) != null)
                return false;
        }

        else if (direction.Equals("down"))
        {
            if (test.GetTile(new Vector3Int(cellPosition.x, cellPosition.y - 1, cellPosition.z)) != null)
                return false;
        }

        return true;
    }

}