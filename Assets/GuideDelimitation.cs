using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
class GuideDelimitation : MonoBehaviour, IPointerDownHandler
{
    Transform guideOrientation;
    void Start()
    {
        guideOrientation = transform.GetChild(0);
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        guideOrientation.position = Mouse.current.position.value;
        guideOrientation.gameObject.SetActive(true);
    }
}