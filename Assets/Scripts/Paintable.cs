using UnityEngine;

public class Paintable : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        sr.color = ColorManager.Instance.SelectedColor;
    }
}