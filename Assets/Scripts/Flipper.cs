using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FlipperType
{
    Right,
    Left,
}

public class Flipper : MonoBehaviour
{
    public FlipperType type;
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
        if (input.Actions.FlipperLeft.WasPressedThisFrame() && type == FlipperType.Left)
        {
            Flip();
        }
        else if (input.Actions.FlipperRight.WasPressedThisFrame() && type == FlipperType.Right)
        {
            Flip();
        }

    }
    public void Flip()
    {
        r.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
