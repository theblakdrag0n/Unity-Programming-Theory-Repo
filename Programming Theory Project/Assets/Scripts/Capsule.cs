using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape  // INHERITANCE
{

    private void Awake()
    {
        BounceForceMultiplier = 6;
    }
}
