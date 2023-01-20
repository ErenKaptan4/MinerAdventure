using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] Text scoreText;
    SaveLoadManager mySaveLoadManager;

    protected override void Awake()
    {
        mySaveLoadManager = new SaveLoadManager();
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        scoreText.text = "Score: " + GameData.Score;
    }
    public void GameOver()
    {
        mySaveLoadManager.DeleteFile();
        SceneManager.LoadScene("GameOver");
    }

    public void Level2()
    {
        mySaveLoadManager.DeleteFile();
        SceneManager.LoadScene("Level2");
    }

}
