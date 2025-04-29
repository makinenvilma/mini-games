using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PuzzleGame()
    {
        SceneManager.LoadScene("PuzzleScene");
    }
    public void PaintGame()
    {
        SceneManager.LoadScene("PaintScene");
    }

     public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}