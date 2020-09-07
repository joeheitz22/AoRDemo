using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    public Transform Rect;
    
    public bool ison = false;


    public GameObject charecter;

    private void Awake()
    {
       
    }
     

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("ss");
        
        ison = true;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        charecter.transform.position = new Vector3(Input.mousePosition.x / 10, 0, Input.mousePosition.y / 10);
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
        charecter.transform.localPosition += Vector3.zero;
    }
}
