using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScreen : MonoBehaviour
{
    private static MouseScreen Instance;

    [SerializeField] private LayerMask mousePlaneLayerMask;

    private void Awake()
    {
        Instance = this;
    }

    public static Vector2 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, Instance.mousePlaneLayerMask);
        return raycastHit.point;
    }
}
