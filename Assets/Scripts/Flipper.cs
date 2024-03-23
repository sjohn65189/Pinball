using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    private Rigidbody r;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Instance.input;
        if (input.Actions.FlipperLeft.WasPressedThisFrame())
        {
            Flip();
            print("pressed");
        }
        else if (input.Actions.FlipperRight.WasPressedThisFrame())
        {
            Flip();
            print("pressed");
        }

    }
    public void Flip()
    {
        r.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
