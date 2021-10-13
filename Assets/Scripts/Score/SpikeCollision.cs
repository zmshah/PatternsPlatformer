// Written by bhavani

using System;
using UnityEngine;

// Handles what happens when player collides with spike
public class SpikeCollision : MonoBehaviour
{
    private static int collisonCounter = 0;

    public SpikeCollision()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisonCounter++;
        SpikeStrategyDelegate2 delegate2 = new SpikeStrategyDelegate2();
        SpikeStrategyDelegate1 delegate1 = new SpikeStrategyDelegate1();

        SpikeStrategy spikeStrategy1 = new SpikeStrategy(spikeDelegate: delegate1);
        SpikeStrategy spikeStrategy2 = new SpikeStrategy(spikeDelegate: delegate2);
        // if player crosses the first spike he gets bonus of 10 points
        // if player crosses the third spike he gets bonus of 30 points
        if (collisonCounter == 1)
        {
            spikeStrategy1.handleStrategies();
        } else if(collisonCounter == 3)
        {
            spikeStrategy2.handleStrategies();
        }
    }
    }

