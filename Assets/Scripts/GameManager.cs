using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void LoadLobbyScene()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void LoadHomeScene()
    {
        SceneManager.LoadScene("Home");
    }
}
