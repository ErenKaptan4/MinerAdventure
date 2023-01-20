using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        GameData.Score = 0;
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
