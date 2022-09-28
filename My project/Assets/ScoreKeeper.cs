using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;

    private int currentScore = 0;
    [SerializeField] private int pointsPerPickup = 5;

    public int GetScore
    {
        get
        {
            return currentScore;
        }
    }


    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public void IncreaseScore()
    {
        currentScore += pointsPerPickup;

    }


}
