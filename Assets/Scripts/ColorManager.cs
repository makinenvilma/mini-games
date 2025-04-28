using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;

    public Color SelectedColor = Color.white;

    private void Awake()
    {
        Instance = this;
    }

    public void SetRed()
    {
        SelectedColor = Color.red;
    }
}
