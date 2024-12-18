using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    // To go back to Menu Scene
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
