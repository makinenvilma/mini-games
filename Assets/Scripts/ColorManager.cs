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

    public void SetBlue()
    {
        SelectedColor = Color.blue;
    }

    public void SetGreen()
    {
        SelectedColor = Color.green;
    }

    public void SetYellow()
    {
        SelectedColor = Color.yellow;
    }

    public void SetOrange()
    {
        SelectedColor = new Color(1f, 0.5f, 0f);
    }
}
