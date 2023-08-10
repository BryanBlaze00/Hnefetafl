using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    [SerializeField] bool isKing;
    [SerializeField] bool isDefender;
    [SerializeField] bool isAttacker;
    


    Vector3 offset;
    Transform dragging = null;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {


        //XXX Dragging 
        if (dragging != null)
        {
            //Move object, taking into account original offset
            dragging.position = SnapClass.Snap(Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset, 1);
        }
    }

    void OnMouseOver()
    {
        //Highlights objects on mouse over
        spriteRenderer.color = Color.yellow;
    }

    void OnMouseExit()
    {
        //un-Highlights objects on mouse exit
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown()
    {
        //XXX Dragging 
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit)
        {
            //if hit, record transform and offset
            dragging = hit.transform;
            offset = dragging.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void OnMouseUp()
    {
        //XXX Dragging Option 2 - Seems to work better..
        dragging = null;
    }
}
