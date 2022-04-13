using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Character personajeMain;
    public int estado;
    public void OnPointerDown(PointerEventData eventData)
    {
        personajeMain.actualButton = this;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        personajeMain.actualButton = null;
    }

    void Start()
    {
        personajeMain = FindObjectOfType<Character>();
    }

    void Update()
    {
        
    }
}
