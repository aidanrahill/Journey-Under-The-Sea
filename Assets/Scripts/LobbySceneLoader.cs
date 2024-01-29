using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneLoader : MonoBehaviour
{
    public void LoadLobbyScene()
    {
        SceneManager.LoadScene("1.0"); // Make sure the scene name matches exactly
    }
}
