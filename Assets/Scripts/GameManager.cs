using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public Text scoreText;
    SaveLoadManager mySaveLoadManager;

    protected override void Awake()
    {
        mySaveLoadManager = new SaveLoadManager();
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        DisplayScore();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    public void GameOver()
    {
        mySaveLoadManager.DeleteFile();
        SceneManager.LoadScene("GameOver");
    }
    public void DisplayScore()
    {
        scoreText.text = GameData.Score.ToString();
    }

    public void Level2()
    {
        mySaveLoadManager.DeleteFile();
        SceneManager.LoadScene("Level2");
        
        
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "GameOver")
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
            DisplayScore();
        }
    }

}
