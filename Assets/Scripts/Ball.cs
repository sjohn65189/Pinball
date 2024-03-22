using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public MainMenu menu;
    private Rigidbody rb;
    public float launchForce;
    private int lives;
    private const int MAX_LIVES = 3;
    public Input input;
    
    // Start is called before the first frame update
    void Start()
    {
        lives = MAX_LIVES;
        rb = GetComponent<Rigidbody>();
        input = new();
        input.Enable();
    }

    public void Launch() {
        float actualLaunchForce = Random.Range(0.9f * launchForce, 1.1f * launchForce);
        rb.AddForce(Vector3.forward * actualLaunchForce, ForceMode.Impulse);
    }

    public void Restart()
    {
        transform.position = GameObject.FindGameObjectWithTag("BallStart").transform.position;
        rb.velocity = Vector3.zero;
        lives = MAX_LIVES;
    }
    private void OnTriggerEnter(Collider other)
    {
        transform.position = GameObject.FindGameObjectWithTag("BallStart").transform.position;
        rb.velocity = Vector3.zero;
        lives--;
        if (lives < 0)
        {
            menu.GameOver();
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Bumper")) {
            Game.Instance.AddScore(10);
        }
    }
    // Update is called once per frame
    void Update()
    {
        print(lives);
        if (input.Actions.lowerLives.WasPressedThisFrame()) {
            lives--;
            if (lives < 0)
            {
                menu.GameOver();
            }
        }
    }
}
