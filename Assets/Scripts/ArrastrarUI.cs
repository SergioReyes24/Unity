using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarUI : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position += (Vector3)eventData.delta;
    }
}
