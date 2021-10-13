//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The abstract positions class
//Has methods for generating positions and getting positions
public abstract class AbstractPositions 
{
    public abstract void GeneratePositions();

    public abstract Vector3 getGroundPosition(int n);

    public abstract Vector3 getUndergroundPosition(int n);

    public abstract Vector3 getSkyPosition(int n);
}
