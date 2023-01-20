using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnMenu : MonoBehaviour
{
    [SerializeField] Button returnButton;
    void Start()
    {
        returnButton.onClick.AddListener(returnToMenu);
    }

    void returnToMenu()
    {
        SceneManager.LoadScene("Welcome");
        GameData.Score = 0;
        GameData.Lifes = 5;
    }
}
