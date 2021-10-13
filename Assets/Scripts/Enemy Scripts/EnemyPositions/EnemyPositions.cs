//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPositions: AbstractPositions
{
    //List of ground enemy positions
    private List<Vector3> groundPositions = new List<Vector3>();

    //List of underground enemy positions
    private List<Vector3> undergroundPositions = new List<Vector3>();

    //List of sky enemy positions
    private List<Vector3> skyPositions = new List<Vector3>();

    //Create positions for each type of enemy
    //Positions are currentl hardcoded but in the future I'd like to create algorithms for automatically deciding which positions to assign
    public override void GeneratePositions()
    {
        GroundPositions();

        UndergroundPositions();

        SkyPositions();
    }

    //Create ground enemy positions
    public void GroundPositions()
    {
        groundPositions.Add(new Vector3(3, -3, 0));
        groundPositions.Add(new Vector3(22, -3, 0));
        groundPositions.Add(new Vector3(41, -3, 0));
    }

    //Create underground enemy positions
    public void UndergroundPositions()
    {
        undergroundPositions.Add(new Vector3(12, -3, 0));
        undergroundPositions.Add(new Vector3(35, -3, 0));
    }

    ////Create sky enemy positions
    public void SkyPositions()
    {
        skyPositions.Add(new Vector3(17, 0, 0));
        skyPositions.Add(new Vector3(44, 0, 0));
    }

    //Get the ground position based on an index
    public override Vector3 getGroundPosition(int n)
    {
        return groundPositions[n];
    }

    //Get the underground position based on an index
    public override Vector3 getUndergroundPosition(int n)
    {
        return undergroundPositions[n];
    }

    //Get the sky position based on an index
    public override Vector3 getSkyPosition(int n)
    {
        return skyPositions[n];
    }
}
