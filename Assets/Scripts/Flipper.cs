using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FlipperType 
{
    LEFT,
    RIGHT,
}

[RequireComponent(typeof(Rigidbody)),
RequireComponent(typeof(AudioSource))]

public class Flipper : MonoBehaviour
{
    public FlipperType type;
    private Rigidbody r;
    public float force;

    private AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Instance.input;
        if (input.Actions.FlipperLeft.WasPressedThisFrame() && type == FlipperType.LEFT)
        {
            Flip();
        }
        else if (input.Actions.FlipperRight.WasPressedThisFrame() && type == FlipperType.RIGHT)
        {
            Flip();
        }

    }
    public void Flip()
    {
        r.AddForce(Vector3.forward * force, ForceMode.Impulse);
        audioSrc.Play();
    }
}
