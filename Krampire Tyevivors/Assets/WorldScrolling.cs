using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScrolling : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector2Int currentTilePosition = new Vector2Int(0,0);
    [SerializeField] Vector2Int playerTilePosition;
    [SerializeField] float tileSize = 20f; 
    GameObject[,] terrainTiles;

    [SerializeField] int terrainTileHorizontalCount;
    [SerializeField] int terrainTileVerticalCount;

    // Start is called before the first frame update
    void Start()
    {
        terrainTiles = new GameObject[terrainTileHorizontalCount, terrainTileVerticalCount];
    }

    private void Update()
    {
        playerTilePosition.x = (int)(playerTransform.position.x / tileSize);
        playerTilePosition.y = (int)(playerTransform.position.y / tileSize);

        if (currentTilePosition != playerTilePosition)
        {
            currentTilePosition = playerTilePosition;
            
        }
    }

    public void Add(GameObject tile, Vector2Int tilePosition)
    {
        terrainTiles[tilePosition.x, tilePosition.y] = tile;
    }
}
