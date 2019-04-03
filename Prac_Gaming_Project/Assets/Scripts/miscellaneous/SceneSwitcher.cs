using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //https://loekvandenouweland.com/content/use-unity-button-to-change-between-scenes.html
    public void GotoGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void GotoControlScene()
    {
        SceneManager.LoadScene("Controls");
    }
}