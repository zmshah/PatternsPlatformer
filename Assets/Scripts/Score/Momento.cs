// Written by bhavani

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ScoreMementoProtocol
{
    int getCurrentScore();
}

public class ScoreMemento: ScoreMementoProtocol
{
    private int score;

    public ScoreMemento(int state)
    {
        this.score = state;
    }

    public ScoreMemento()
    {

    }

    // get the current score
    public int getCurrentScore()
    {
        return score;
    }
}

// Used to take the snapshot of the player score at the time of kill
class SnapshotOriginator
{
    private int state;

    public SnapshotOriginator(int state)
    {
        this.state = state;
    }

    public void updateScore(int newScore)
    {
        this.state = newScore;
    }

    // call update before save
    public ScoreMementoProtocol SaveScore()
    {
        return new ScoreMemento(this.state);
    }

    // get the most recent score from the snapshots
    public void Restore(ScoreMementoProtocol memento)
    {
        this.state = memento.getCurrentScore();
    }
}

// To keep track of the hisotry of scores
class ScoreKeeper
{
    private List<ScoreMementoProtocol> _mementos = new List<ScoreMementoProtocol>();

    private SnapshotOriginator _originator = null;

    public ScoreKeeper(SnapshotOriginator originator)
    {
        this._originator = originator;
    }

    public void RecordScore()
    {
        this._mementos.Add(this._originator.SaveScore());
    }

    public void ShowPlayHistoryScores()
    {
        foreach (var memento in this._mementos)
        {
            Debug.Log(memento.getCurrentScore());
        }
    }
}