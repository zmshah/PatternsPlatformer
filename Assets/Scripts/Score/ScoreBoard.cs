// Written by bhavani

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Singleton class to keep track of the score for player at any moment of play
public sealed class ScoreBoard
{
    private ScoreBoard()
    {
    }

    private static ScoreBoard sharedInstance = null;
    

    public static ScoreBoard shared

    {
        get
        {
            if (sharedInstance == null)
            {
                sharedInstance = new ScoreBoard();
            }
            return sharedInstance;
        }
    }

    private int points = 0;

    public int GetPoints()
    {
        return points;
    }

    public void AddPoints(int points)
    {
        this.points += points;
      
    }
}
