using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Collider col;

    void Start() {
        col = GetComponent<Collider>();
        col.enabled = false;
    }

    public void OpenDoor() {
        col.enabled = false;
    }

    public void CloseDoor() {
        col.enabled = true;
    }
}
