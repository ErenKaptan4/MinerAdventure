using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    private static int myScore = 0;

    public static int Score
    {
        get { return myScore; }
        set { myScore = value; }
    }
}
