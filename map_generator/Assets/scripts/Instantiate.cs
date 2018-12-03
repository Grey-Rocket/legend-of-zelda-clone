using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    //public Transform sea;
    public Transform land;

    private GameObject parent;

    public int stranica = 20;
    void Start()
    {

        Generiraj();
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Destroy(parent);
            Generiraj();
        }
    }

    void Generiraj()
    {
        parent = new GameObject("parent");

        for (int y = 0; y < stranica; y++)
        {
            for (int x = 0; x < stranica; x++)
            {

                Instantiate(land, new Vector3(0.4f * (x-10), 0.4f * (y-10), 0), Quaternion.identity, parent.transform);

            }

        }

    }
}
