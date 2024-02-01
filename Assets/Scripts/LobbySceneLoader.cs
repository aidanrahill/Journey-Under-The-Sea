using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneLoader : MonoBehaviour
{
    public void LoadLobbyScene()
    {
        SceneManager.LoadScene("Lobby Scene"); // Make sure the scene name matches exactly
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
