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

    //TODO - Remove after looked over --> Dragging option 1
    // bool isDragging = false;

    //XXX Dragging Option 2 - Seems to work better..
    Vector3 offset;
    Transform dragging = null;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        //TODO - Remove after looked over --> Dragging option 1
        // if (isDragging)
        // {
        //     transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        // }


        //XXX Dragging Option 2 - Seems to work better..
        if (dragging != null)
        {
            //Move object, taking into account original offset
            dragging.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
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
        //TODO - Remove after looked over --> Dragging option 1
        // offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        // isDragging = true;


        //XXX Dragging Option 2 - Seems to work better.. 
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero
        /** Optional - adds to Raycat() for layer distinction: , float.PositiveInfinity, LayerMask.GetMask("Layer-name"**/
                                                                                                );
        if (hit)
        {
            //if hit, record transform and offset
            dragging = hit.transform;
            offset = dragging.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void OnMouseUp()
    {
        //TODO - Remove after looked over --> Dragging option 1
        // isDragging = false;

        //XXX Dragging Option 2 - Seems to work better..
        dragging = null;
    }
}
