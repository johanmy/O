using UnityEngine;
using UnityEngine.EventSystems;
class MobileJoystick : MonoBehaviour, IPointerDownHandler
{
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        print(777);
    }
}