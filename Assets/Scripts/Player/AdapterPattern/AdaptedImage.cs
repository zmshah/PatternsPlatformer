// Written by Nishitha
// Adapter pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdaptedImage : ColorAdapter
{
    // This class works with image
    Image adaptee;

    public AdaptedImage(Image adaptee)
    {
        this.adaptee = adaptee;
    }

    public override Color color
    {
        get => adaptee.color; set => adaptee.color = value;
    }
}