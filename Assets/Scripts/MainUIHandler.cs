using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public Text mainHighScore;

    void Start()
    {
        if (GameManager.Instance.highScore != 0)
        {
            mainHighScore.text = $"Best Score : {GameManager.Instance.highScoreName} : {GameManager.Instance.highScore}";
        }
    }


    // To go back to Menu Scene
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
