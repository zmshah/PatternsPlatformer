//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The concrete iterator class
public class ConcreteIterator : Iterator
{
    //Create a new concrete aggregate object
    private ConcreteAggregate aggregate;

    //Set the current object to the first item
    private int current = 0;

    //Constructor
    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    //Gets first item in the iteration\
    public override object First()
    {
        return aggregate[0];
    }

    //Next item in the iteration
    public override object Next()
    {
        object item = null;
        if (current < aggregate.Count - 1)
        {
            item = aggregate[current++];
        }
        return item;
    }

    //Current item in iteration
    public override object Current()
    {
        return aggregate[current];
    }

    //Check to see if the iteration is complete by seeing if the pointer is at the last item in the arry
    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }

    //Checks if iterations are complete by checking if array has a next item
    public override bool HasNext()
    {
        if(current>=aggregate.Count || aggregate[current] == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
