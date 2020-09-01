using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    public RectTransform Rect;
    
    public bool ison = false;


    public GameObject charecter;

    private void Awake()
    {
        Rect = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("ss");
        
        ison = true;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        charecter.transform.position += new Vector3(eventData.delta.x, eventData.delta.y);
    }

   public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("mm");
        Instantiate(charecter, Rect.transform);
        ison = true;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("sizz");
        ison = false;
    }
}
