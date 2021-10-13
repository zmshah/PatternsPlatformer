using System;
using System.Collections.Generic;
using UnityEngine;

public class SpikeModel
{
    private List<Vector3> spikePositions = new List<Vector3>();

    public List<Vector3> SpikePositions { get => spikePositions; set => spikePositions = value; }

    // List of all locations for spikes in the platform
    public void setSpikePostions() {
        SpikePositions.Add(new Vector3(-2.29f, -3.28f, 0));
        SpikePositions.Add(new Vector3(4.11f, -3.36f, 0));
        SpikePositions.Add(new Vector3(12.11f, -3.36f, 0));
        SpikePositions.Add(new Vector3(22.48f, -3.36f, 0));
        SpikePositions.Add(new Vector3(37.49f, -3.28f, 0));
    }

    public SpikeModel() {
    }
}