using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSelectedVisual : MonoBehaviour
{
    [SerializeField] private Piece piece;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        PieceActionSystem.Instance.OnSelectedPieceChanged += PieceActionSystem_OnSelectedPieceChanged;
    }

    private void PieceActionSystem_OnSelectedPieceChanged(object sender, EventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        if (PieceActionSystem.Instance.GetSelectedPiece() == piece)
        {
            spriteRenderer.color = Color.yellow;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }
}