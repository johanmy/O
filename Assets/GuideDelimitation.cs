using UnityEngine;
using UnityEngine.EventSystems;
class GuideDelimitation : MonoBehaviour, IPointerDownHandler
{
    GuideOrientation guideOrientation;
    void Start()
    {
        guideOrientation = transform.GetChild(0).GetComponent<GuideOrientation>();
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        guideOrientation.Localize();
    }
}