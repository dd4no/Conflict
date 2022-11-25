using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject Tile;
    private int boardSize = 24;

    void Start()
    {
        for (int z = 0; z < boardSize; z++)
        {
            for (int x = 0; x < boardSize; x++)
            {
                var gameTile = Instantiate(Tile, new Vector3(x, 0, z), transform.rotation);
                gameTile.name = $"{x},{z}";
            }

        }
    }

    void Update()
    {
        
    }
}
