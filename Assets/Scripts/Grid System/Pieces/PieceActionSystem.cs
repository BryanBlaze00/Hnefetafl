using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceActionSystem : MonoBehaviour
{
    public static PieceActionSystem Instance { get; private set; }

    public event EventHandler OnSelectedPieceChanged;

    [SerializeField] private Piece selectedPiece;
    [SerializeField] private LayerMask pieceLayerMask;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log($"There is more than one Piece Action System: {transform} - {Instance}");
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(TryHandlePieceSelection()) { return; }

            selectedPiece.Move(MouseScreen.GetPosition());
        }
    }

    private bool TryHandlePieceSelection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D raycastHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, float.MaxValue, pieceLayerMask);

        if(raycastHit)
        {
            if (raycastHit.transform.TryGetComponent(out Piece piece))
            {
                SetSelectedPiece(piece);
                return true;
            }
        }

        return false;
    }

    private void SetSelectedPiece(Piece piece)
    {
        selectedPiece = piece;
        OnSelectedPieceChanged?.Invoke(this, EventArgs.Empty);
    }

    public Piece GetSelectedPiece()
    {
        return selectedPiece;
    }
}