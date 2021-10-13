//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The abstract iterator class
public abstract class Iterator
{
    //Get the first item
    public abstract object First();

    //Get the next item
    public abstract object Next();

    //Get the current item pointed by the iterator
    public abstract object Current();

    //Check to see if iteration is complete
    public abstract bool IsDone();

    //Check to see if the array has a next item
    public abstract bool HasNext();
}
