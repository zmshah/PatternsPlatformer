//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Concrete Aggregate class
public class ConcreteAggregate : Aggregate
{
    //Array list of gameobjects. Can be any object. Currently being used to create array of enemy objects
    private List<object> items = new List<object>();

    //Create Iterator
    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    //Gets array count
    public int Count
    {
        get { return items.Count; }
    }

    //Indexer to get an item from the array
    public object this[int index]
    {
        get { return items[index]; }
    }

    //Add item to the array
    public void Add(object item)
    {
        items.Add(item);
    }

    //Remove item from the array
    public void Remove(object item)
    {
        items.Remove(item);
    }

    //Get the index of the item
    public int IndexOf(object item)
    {
        return items.IndexOf(item);
    }
}