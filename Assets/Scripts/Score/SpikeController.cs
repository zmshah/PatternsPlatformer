using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// intializes all the spikes on the platform
public class SpikeController : MonoBehaviour
{
    //spike 
    [SerializeField]
    private GameObject Spike;

    //spike2 
    [SerializeField]
    private GameObject spike2;

    
    [SerializeField]
    private GameObject spike3;

    [SerializeField]
    private GameObject spike4;

    [SerializeField]
    private GameObject spike5;

    List<GameObject> spikes = new List<GameObject>();
    

    public SpikeModel spikeModel = new SpikeModel();

    void Start()
    {
        populateSpikesList();
        positions();
        CreateSpikes();
    }

    // create and load all spikes to platform using a Factory
    private List<GameObject> CreateSpikes()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject obj = SpikeFactory.CreateObstacle(ObstacleType.spike, spikeModel.SpikePositions[i], spikes[i]).GetGameSpike();
        }
        return spikes;
    }

    // get all the spikes on platform
    public void populateSpikesList()
    {
        spikes.Add(Spike);
        spikes.Add(spike2);
        spikes.Add(spike3);
        spikes.Add(spike4);
        spikes.Add(spike5);
    }

    // get positions for spikes
    public void positions()
    {
        spikeModel.setSpikePostions();
    }
}
