using UnityEngine;
using UnityEngine.EventSystems;
class GuideDelimitation : MonoBehaviour, IPointerDownHandler
{
    GuideOrientation guideOrientation;
    void Start()
    {
        guideOrientation = GetComponentInChildren<GuideOrientation>(false);
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        guideOrientation.Localize();
    }
}