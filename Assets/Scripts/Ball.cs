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

    /**new life function resets ball position and decreases lives. activates game over screen if necessary.**/
    public void NewLife() {
        transform.position = GameObject.FindGameObjectWithTag("BallStart").transform.position;
        rb.velocity = Vector3.zero;
        lives--;
        if (lives < 0) { menu.GameOver();  }
    }

    private void OnTriggerEnter(Collider other)
    {

        // check the tag of what I collided with. If it is the ball end, play sound and reset ball
        if (other.CompareTag(Consts.Tags.BALL_END)) {
            other.gameObject.GetComponent<AudioSource>().Play();
            NewLife();
        }

        //target trigger; add target score, and notify target that it has been triggered
        if (other.CompareTag(Consts.Tags.TARGET)) 
        {
            var target = other.GetComponent<Target>();
            target.Hit();
            Game.Instance.AddScore(Consts.Points.HIT_TARGET);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        //bumper collision; add bumper score, and notify bumper that ball collided
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null) {
            bumper.Bump();
            Game.Instance.AddScore(Consts.Points.HIT_BUMPER);
        }

        //flipper collision; add flipper score
        var flipper = collision.gameObject.GetComponent<Flipper>();
        if (flipper != null) {
            Game.Instance.AddScore(Consts.Points.HIT_FLIPPER);
        }
    }
    // Update is called once per frame
    void Update()
    {

        //if space key is pressed, launch the ball.
        if (input.Actions.LaunchBall.WasReleasedThisFrame()) { Launch(); }

        //if w key is pressed, lower lives
        if (input.Actions.lowerLives.WasPressedThisFrame()) {
            lives--;
            if (lives < 0)
            {
                menu.GameOver();
            }
        }
    }
}
