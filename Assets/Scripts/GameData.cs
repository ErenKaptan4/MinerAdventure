using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    private static int myScore = 0;

    public static int Score
    {
        get { return myScore; }
        set { myScore = value; }
    }

    private static int mylifes = 5;

    public static int Lifes
    {
        get { return mylifes; }
        set { mylifes = value; }
    }

}
