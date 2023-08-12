using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    static int _width, _height;

    [SerializeField] Tile _darkTile, _lightTile;

    [SerializeField] Transform _cam;

    [SerializeField] Transform _gridManager;
    bool hasClickedPlay = false;

    // Tile Coordinates Grid / List
    private static readonly Transform[,] _grid = new Transform[_width, _height];
    public static List<Vector2Int> TileCoordList { get; set; } = new List<Vector2Int>();


    public GridManager()
    {
        _width = 13;
        _height = 13;
    }

    public Vector2Int GetTileCoord(int x, int y)
    {
        return (Vector2Int)_grid.GetValue(x, y);
    }

    public Transform GetTilePos(int x, int y)
    {
        return (Transform)_grid.GetValue(x, y);
    }

    void Start()
    {

        GenerateGrid();


    }

    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                bool isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                Tile offsetTile = isOffset ? _darkTile : _lightTile;

                Tile spawnedTile = Instantiate(offsetTile, new Vector3(x, y), Quaternion.identity, _gridManager);
                spawnedTile.name = $"Tile {x} {y}";

                // Initialize Coordinates List of Tiles
                var coordinates = new Vector2Int(x, y);
                TileCoordList.Add(coordinates);
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
    }

}
