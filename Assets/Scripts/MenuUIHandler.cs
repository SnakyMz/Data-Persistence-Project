using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // To start a new game
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // To exit the game
    public void Exit()
    {
        Application.Quit();
    }
}
