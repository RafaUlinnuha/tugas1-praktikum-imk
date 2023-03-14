using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject _panel;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string scene) 
    {
        SceneManager.LoadScene(scene);
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        _panel.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        _panel.SetActive(false);
    }
}
