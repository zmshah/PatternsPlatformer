//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Proxy class for creating and assigning positions
//Currently the positions are being hardcoded but in the future I'd like to create a different algorithm for 
//generating positions. The proxy class ensures that the position algorithms are decoupled from the enemy spawner
//class when assigning each enemy a position and access to the original positions object is controller. This way
//I can change the algorithms in the future without worrying about the implementation on the enemy controller
public class ProxyPosition : AbstractPositions
{
    private AbstractPositions realPositions = null;

    public ProxyPosition(AbstractPositions realPositions)
    {
        this.realPositions = realPositions;
    }

    public override void GeneratePositions()
    {
        this.realPositions.GeneratePositions();
    }

    public override Vector3 getGroundPosition(int n)
    {
        return this.realPositions.getGroundPosition(n);
    }

    public override Vector3 getUndergroundPosition(int n)
    {
        return this.realPositions.getUndergroundPosition(n);
    }

    public override Vector3 getSkyPosition(int n)
    {
        return this.realPositions.getSkyPosition(n);
    }
}
