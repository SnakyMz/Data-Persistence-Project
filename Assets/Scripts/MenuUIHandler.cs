using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerName;
    public TextMeshProUGUI menuHighScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.Instance.LoadHighScore();
        if(GameManager.Instance.highScore != 0)
        {
            menuHighScore.text = GameManager.Instance.highScoreName + " : " + GameManager.Instance.highScore;
        }
    }

    // To start a new game
    public void StartNew()
    {
        GameManager.Instance.nameText = playerName.text;
        SceneManager.LoadScene(1);
    }

    // To exit the game
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
