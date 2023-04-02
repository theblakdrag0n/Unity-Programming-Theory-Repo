using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected const float baseBounceForce = 100.0f;

    [SerializeField]
    protected float m_bounceForceMultiplier;  // ENCAPSULATION

    protected float BounceForceMultiplier   // ENCAPSULATION
    {  
        get { return m_bounceForceMultiplier;}
        set { m_bounceForceMultiplier = value; }
    }

    protected virtual void Bounce()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, baseBounceForce * BounceForceMultiplier, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce();  // ABSTRACTION
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
