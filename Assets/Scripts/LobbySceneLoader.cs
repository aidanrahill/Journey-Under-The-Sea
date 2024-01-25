using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneLoader : MonoBehaviour
{
    public void LoadLobbyScene()
    {
        SceneManager.LoadScene("Lobby Scene"); // Make sure the scene name matches exactly
    }
    public void LoadMenuScene ()
    {
        SceneManager.LoadScene("Menu");
    }
    public void quit()
{
    #if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
    #else
    Application.Quit();
    #endif
}

}
