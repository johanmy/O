using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
class Guide : MonoBehaviour, IPointerDownHandler
{
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Transform joystickOutline = transform.Find("Canvas/JoystickField/JoystickOutline");
        joystickOutline.position = Mouse.current.position.value;
    }
}