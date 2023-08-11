using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject
{
    private GridSystem gridSystem;
    private GridPosition gridPosition;
    private List<Piece> pieceList;

    //Constructor takes a grid system and a grid position for this object
    public GridObject(GridSystem gridSystem, GridPosition gridPosition)
    {
        this.gridSystem = gridSystem;
        this.gridPosition = gridPosition;
        pieceList = new List<Piece>();
    }

    //ToString() override to show the piece(s) on the grid object
    public override string ToString()
    {
        string pieceString = "";
        foreach (Piece piece in pieceList) 
        {
            pieceString += piece + "\n";
        }

        return gridPosition.ToString() + "\n" + pieceString;
    }

    //Functions to add to, remove from, and get the list of pieces on the grid object
    public void AddPiece(Piece piece) 
    { 
        pieceList.Add(piece);
    }

    public void RemovePiece(Piece piece) 
    { 
        pieceList.Remove(piece);
    }

    public List<Piece> GetPieceList()
    { 
        return pieceList;
    }
}