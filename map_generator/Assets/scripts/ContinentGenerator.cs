using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public Transform sea;
    public Transform land;

    private GameObject parent;

    public int stranica = 20;
    void Start()
    {
        arr = new Transform[] { land, forrest, mountain, grassland };

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

        int st_polj = 0;

        for (int i = 0; i < stranica * stranica; i++)
        {
            if ((int)Random.Range(0, 2) == 1)
            {
                st_polj++;
            }

        }

}
