// Written by Nishitha
// Adapter pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptedSpriteRender : ColorAdapter
{
    // This class works with spriterenderer
    SpriteRenderer adaptee;

    public AdaptedSpriteRender(SpriteRenderer adaptee)
    {
        this.adaptee = adaptee;
    }

    public override Color color
    {
        get => adaptee.color; set => adaptee.color = value;
    }
}
