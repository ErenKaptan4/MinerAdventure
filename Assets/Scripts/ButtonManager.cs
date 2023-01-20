using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] Button startButton, exitButton, difficultyButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(QuitGame);
        difficultyButton.onClick.AddListener(ChangeDifficulty);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
    }

    bool buttonPressed = false;
    void ChangeDifficulty()
    {
        
        if(buttonPressed == false)
        {
            GameData.Lifes = 10;
            buttonPressed = true;
        }else if(buttonPressed == true)
        {
            GameData.Lifes = 5;
            buttonPressed = false;
        }
        Debug.Log(GameData.Lifes);
    }
}
