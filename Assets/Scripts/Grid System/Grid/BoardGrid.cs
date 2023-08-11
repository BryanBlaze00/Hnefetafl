using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGrid : MonoBehaviour
{
    public static BoardGrid Instance { get; private set; }

    [SerializeField] private Transform gridDebugObjectPrefab;

    private GridSystem gridSystem;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log($"There is more than one Board Grid: {transform} - {Instance}");
            Destroy(gameObject);
            return;
        }

        Instance = this;

        gridSystem = new GridSystem(13, 13, 1f);
        gridSystem.CreateDebugObjects(gridDebugObjectPrefab);
    }

    public void AddPieceAtGridPosition(GridPosition gridPosition, Piece piece)
    {
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);
        gridObject.AddPiece(piece);
    }

    public List<Piece> GetPieceListAtGridPosition(GridPosition gridPosition)
    {
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);
        return gridObject.GetPieceList();
    }

    public void RemovePieceAtGridPosition(GridPosition gridPosition, Piece piece)
    {
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);
        gridObject.RemovePiece(piece);
    }

    public void PieceMovedGridPosition(Piece piece, GridPosition fromGridPosition,  GridPosition toGridPosition)
    {
        RemovePieceAtGridPosition(fromGridPosition, piece);
        AddPieceAtGridPosition(toGridPosition, piece);
    }

    public GridPosition GetGridPosition(Vector3 screenPosition) => gridSystem.GetGridPosition(screenPosition);
}