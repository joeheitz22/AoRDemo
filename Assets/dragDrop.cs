using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour//, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    public Transform Rect;
    
    public bool ison = false;


    public GameObject charecter;

    Ray ray;

    GameObject chare;

    

    private void Awake()
    {
        
    }

    private void Update()
    {



        if (Input.GetMouseButtonDown(0) && ison == false)
        {
            ison = true;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //charecter.transform.position = new Vector3(Input.mousePosition.x / 100, 0, Input.mousePosition.y / 100);

            if (Physics.Raycast(ray))
            {
                 Debug.Log("we hit clicked on something"); // Find a way to figure out what object you hit

                 chare = Instantiate(charecter, Rect);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            ison = false;
        }



        if (ison == true)
        {
            chare.transform.position = new Vector3(Input.mousePosition.x / 100 - 10, 3, Input.mousePosition.y / 100 -5);
        }
    }


    // public void OnBeginDrag(PointerEventData eventData)
    // {
    //     Debug.Log("ss");

    //     ison = true;
    // }
    // public void OnDrag(PointerEventData eventData)
    // {
    //     Debug.Log("Drag");
    //     charecter.transform.position = new Vector3(Input.mousePosition.x / 10, 0, Input.mousePosition.y / 10);
    // }

    //public void OnPointerDown(PointerEventData eventData)
    // {
    //     Debug.Log("mm");
    //     Instantiate(charecter, Rect.transform);
    //     ison = true;
    // }
    // public void OnEndDrag(PointerEventData eventData)
    // {
    //     Debug.Log("sizz");
    //     charecter.transform.localPosition += Vector3.zero;
    // }
}
