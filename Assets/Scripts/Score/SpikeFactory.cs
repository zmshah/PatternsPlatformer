// Written by Bhavani

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Spike factory can create multiple types of spikes using ObstacleType
// An initialized Game object of type IObstacle is manufactured here
public class SpikeFactory : MonoBehaviour
{
    public static IObstacle CreateObstacle(ObstacleType type, Vector3 position, GameObject obj)
    {
        switch (type)
        {
            case ObstacleType.spike:
                Spike spk = new Spike(obj, position);
                return spk;

            default:
                throw new ArgumentException("Invalid type", "type");
        }
    }
}

// Obstacle behaviors
public interface IObstacle
{
    GameObject GetGameSpike();
    void killPlayer();
}

// list the types of Obstacles here
public enum ObstacleType
{
    spike
}


public class Spike : IObstacle
{
    private GameObject spike;
    private Vector3 position;

    public void killPlayer()
    {
        throw new NotImplementedException();
    }

    public GameObject GetGameSpike()
    {
        return spike;
    }

    public Spike(GameObject obj, Vector3 position)
    {
        this.position = position;
        this.spike = GameObject.Instantiate(obj, position, Quaternion.identity);
    }
}

