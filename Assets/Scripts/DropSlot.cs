using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public string correctPieceName;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        if (dropped != null && dropped.name == correctPieceName)
        {
            dropped.transform.position = transform.position;
            dropped.GetComponent<DraggablePiece>().enabled = false;
        }
        else
        {
            dropped.GetComponent<DraggablePiece>().ResetPosition();
        }
    }
}
