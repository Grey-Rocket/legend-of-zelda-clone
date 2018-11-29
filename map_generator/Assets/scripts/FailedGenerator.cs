using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedGenerator : MonoBehaviour
{

    public Transform sea;
    public Transform land;
    public Transform forrest;
    public Transform mountain;
    public Transform grassland;

    private Transform[] arr;
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

        int[,] tabela = new int[stranica, stranica];


        for (int y = 0; y < stranica; y++)
        {
            for (int x = 0; x < stranica; x++)
            {
                float postavitev = 0.5f;

                if ((stranica * stranica - (y * stranica + x)) < st_polj || (x == 0 && y == 0 ) || st_polj == 0)
                {
                    if ((stranica * stranica - (y * stranica + x)) > st_polj && (st_polj == 0 || Random.Range(0.0f, 1.1f) >= postavitev))
                    {
                        Instantiate(sea, new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                        tabela[0, 0] = 0;
                    }

                    else
                    {
                        Instantiate(land, new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                        //Instantiate(arr[Random.Range(0, arr.Length)], new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                        tabela[0, 0] = 1;
                        st_polj--;
                    }
                }

                else
                {

                    if (x > 0)
                    {
                        if (tabela[y, x - 1] == 0)
                        {
                            postavitev += 0.2f;

                        }
                        else
                        {
                            postavitev -= 0.1f;
                        }
                    }

                    if (y > 0)
                    {
                        if (tabela[y - 1, x] == 0)
                        {
                            postavitev += 0.2f;

                        }
                        else
                        {
                            postavitev -= 0.1f;
                        }
                    }

                    //Debug.Log(postavitev);
                    if (Random.Range(0.0f, 1.1f) >= postavitev)
                    {
                        Instantiate(sea, new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                        tabela[y, x] = 0;
                    }
                    else
                    {
                        Instantiate(land, new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                        //Instantiate(arr[Random.Range(0, arr.Length)], new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                        st_polj--;
                        tabela[y, x] = 1;
                    }

                }

            }
        }

    }

}

/*
 * za randomly generiranje sveta
    if ((int)Random.Range(0, 2) == 0)
                {
                    Instantiate(sea, new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);
                }
                else
                {
                    Instantiate(arr[(int)Random.Range(0, arr.Length)], new Vector3(0.4f * x, 0.4f * y, 0), Quaternion.identity, parent.transform);

                }
 */
