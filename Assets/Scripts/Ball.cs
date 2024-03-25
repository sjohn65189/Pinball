using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody)),
 RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    public MainMenu menu;
    private Rigidbody rb;
    public float launchForce;
    private int lives;
    private const int MAX_LIVES = 4;
    private AudioSource audioSrc;   // audio source attached to the ball. This is set in Start method
    public Input input;
    public GameObject[] ballLives;
    private bool canBeLaunched;      // flag to prevent launching multiple times
    
    // Start is called before the first frame update
    void Start()
    {
        lives = MAX_LIVES;
        rb = GetComponent<Rigidbody>();
        input = new();
        input.Enable();
        audioSrc = GetComponent<AudioSource>();
        canBeLaunched = true;
    }

    public void Launch() {
        float actualLaunchForce = Random.Range(0.9f * launchForce, 1.1f * launchForce);
        rb.AddForce(Vector3.forward * actualLaunchForce, ForceMode.Impulse);
        
        // prevent it from being launched again.
        // This might be problematic if the force isn't high enough to get the ball
        // into the game board.
        // canBeLaunched is set back to true when ball is reset
        canBeLaunched = false;

        // play launch audio clip. The proper clip is already set in the AudioSource in Unity's inspector
        audioSrc.Play();
    }

    public void Restart()
    {
        transform.position = GameObject.FindGameObjectWithTag(Consts.Tags.BALL_START).transform.position;
        rb.velocity = Vector3.zero;
        lives = MAX_LIVES;
    }
    private void OnTriggerEnter(Collider other)
    {
        // check the tag of what I collided with. If it is the ball end, play sound and reset ball
        if (other.CompareTag(Consts.Tags.BALL_END)) {
            other.gameObject.GetComponent<AudioSource>().Play();
            ResetBall();
        } 
        
        else if (other.CompareTag(Consts.Tags.TARGET)) {
            var target = other.GetComponent<Target>();
            target.Hit();
            Game.Instance.AddScore(Consts.Points.HIT_TARGET);
        }
    }
    private void OnCollisionEnter(Collision collision) {
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null) 
        {
            bumper.Bump();
            Game.Instance.AddScore(Consts.Points.HIT_BUMPER);
        }
        // if we didn't hit a bumper, did we hit a flipper?
        else if (collision.gameObject.tag.StartsWith(Consts.Tags.FLIPPER)) {
            // if so, add a small amount of points
            Game.Instance.AddScore(Consts.Points.HIT_FLIPPER);
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

    public void ResetBall() 
    {
        // reset the ball's position and clear any lingering velocity
        transform.position = GameObject.FindGameObjectWithTag(Consts.Tags.BALL_START).transform.position;
        rb.velocity = Vector3.zero;

        // decrement lives and update lives GUI
        ballLives[MAX_LIVES - lives].SetActive(false);
        lives--;

        // show game over if no lives are left
        if (lives <= 0) {
            menu.GameOver();
        }
        // if not game over, allow the ball to be launched again
        else {
            canBeLaunched = true;
        }
    }
}
