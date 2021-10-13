// Written by bhavani

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
public class SpikeStrategy
{
    public ISpikeStrategy spikeDelegate;

    public SpikeStrategy(ISpikeStrategy spikeDelegate)
    {
        this.spikeDelegate = spikeDelegate;
    }

   public void handleStrategies()
    {
        spikeDelegate.landedOnSpike();
    }
}


public interface ISpikeStrategy
{
    void landedOnSpike();
}

public class SpikeStrategyDelegate1 : ISpikeStrategy
{
    public void landedOnSpike()
    {
        // Add bonus points for spike 1
        ScoreBoard.shared.AddPoints(10);
    }
}

public class SpikeStrategyDelegate2 : ISpikeStrategy
{
    public void landedOnSpike()
    {
        // Add bonus points for spike 3
        ScoreBoard.shared.AddPoints(30);
    }
}