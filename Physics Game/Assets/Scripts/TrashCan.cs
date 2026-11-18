using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrashCan : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool IsPointerOverTrash { get; private set; }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer is over trash");
        IsPointerOverTrash = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        IsPointerOverTrash = false;
    }
}
