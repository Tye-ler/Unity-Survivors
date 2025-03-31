using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScrolling : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector2Int currentTilePosition;
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
        Vector2Int playerTilePosition = new Vector2Int(Mathf.FloorToInt(playerTransform.position.x), Mathf.FloorToInt(playerTransform.position.y));
        if (playerTilePosition != currentTilePosition)
        {
            currentTilePosition = playerTilePosition;
            UpdateTerrainTiles();
        }
    }

    public void Add(GameObject tile, Vector2Int tilePosition)
    {
        terrainTiles[tilePosition.x, tilePosition.y] = tile;
    }
}
