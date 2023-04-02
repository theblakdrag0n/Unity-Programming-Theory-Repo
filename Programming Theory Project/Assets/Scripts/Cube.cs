using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cube : Shape  // INHERITANCE
{

    private void Awake()
    {
        BounceForceMultiplier = 2;
    }

    protected override void Bounce()  // POLYMORPHISM
    {
        base.Bounce();

        // Change object color randomly on bounce
        float red = Random.Range(0f, 1f);
        float green = Random.Range(0f, 1f);
        float blue = Random.Range(0f, 1f);

        Color newColor = new(red, green, blue);
        gameObject.GetComponent<Renderer>().material.color = newColor;
    }

}
