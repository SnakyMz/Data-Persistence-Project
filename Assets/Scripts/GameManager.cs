using System;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string nameText;
    public string highScoreName;
    public int highScore = 0;



    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class HighScoreData
    {
        public string playerName;
        public int score;
    }

    public void SaveHighScore(string playerName, int score)
    {
        HighScoreData data = new HighScoreData();
        highScoreName = playerName;
        highScore = score;
        data.playerName = playerName;
        data.score = score;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savescore.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savescore.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScoreData data = JsonUtility.FromJson<HighScoreData>(json);
            highScoreName = data.playerName;
            highScore = data.score;
        }
    }
}
