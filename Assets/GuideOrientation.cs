using UnityEngine;
using UnityEngine.InputSystem;
class GuideOrientation : MonoBehaviour
{
    //bool active;
    RectTransform rectTransform;
    //Vector2 mouseCurrentPosition;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        //gameObject.SetActive(false);
    }
    //void Update()
    //{
    //    if (active)
    //    {
    //        Vector2 value = mouseCurrentPosition - Mouse.current.position.value;
    //    }
    //}
    internal void Localize()
    {
        rectTransform.position = Mouse.current.position.value;
        //mouseCurrentPosition = Mouse.current.position.value;
        //RectTransform.position = Mouse.current.position.value;
        //guideOrientation.gameObject.SetActive(true);
        //active = guideOrientation.gameObject.activeSelf;
    }
    //internal void v()
    //{
    //    mouseCurrentPosition = Mouse.current.position.value;
    //    transform.position = mouseCurrentPosition;
    //}
}