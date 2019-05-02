using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour{

    private ChangeText textChange;

    void Start()
    {
        textChange = GetComponent<ChangeText>();
    }

    //https://loekvandenouweland.com/content/use-unity-button-to-change-between-scenes.html
    public void GotoFightScene()
    {
        textChange.TextChange();
        SceneManager.LoadScene("Fight");
    }

    public void GotoControlScene()
    {
        SceneManager.LoadScene("Controls");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}