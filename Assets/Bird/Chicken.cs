using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    AudioManager audioManager;
    public AudioSource audioPlayer;
    private Vector3 _initialPosition;
    private bool _birdWasLaunched;
    private float _timeSittingAround;
    private float _initialAngVel;
    public Rigidbody2D rb;
    [SerializeField] private float _LaunchPower = 300;
    [SerializeField] private float maxDragDistance = 4;
    [SerializeField] Lives live;
   

   public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _initialPosition = transform.position;
        rb.gravityScale = 0;
        _initialAngVel = rb.angularVelocity;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Update()
    {


        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);
        GetComponent<LineRenderer>().SetPosition(0, transform.position);

        if (_birdWasLaunched &&
            rb.velocity.magnitude <= 0.05)
        {
            _timeSittingAround += Time.deltaTime;
        }


        if (transform.position.y > 20 || transform.position.y < -20 ||
            transform.position.x > 20 || transform.position.x < -20 ||
            _timeSittingAround > 3)
        {
            _birdWasLaunched = false;
            transform.position = _initialPosition;
            rb.gravityScale = 0;
            _timeSittingAround = 0;
            rb.velocity = Vector2.zero;
            rb.angularVelocity = _initialAngVel;
            transform.rotation = Quaternion.identity;

        }
        else if (live.currentLives <= 0 && rb.velocity == Vector2.zero && _timeSittingAround > 2 || live.currentLives < 0)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
        else if (live.currentLives < 0)
        {
            _birdWasLaunched = true;
        }

    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        GetComponent<LineRenderer>().enabled = true;
        live.LoseLive(1);

    }
    private void OnMouseUp()
    {

        GetComponent<SpriteRenderer>().color = Color.white;

        Vector2 directionToInitialPosition = _initialPosition - transform.position;

        rb.AddForce(directionToInitialPosition * _LaunchPower);
        rb.gravityScale = 1;
        _birdWasLaunched = true;
        audioManager.PlaySFX(audioManager.shootTheChicken);
        GetComponent<LineRenderer>().enabled = false;
    }

    private void OnMouseDrag()
    {

        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;
        if (Vector2.Distance(newPosition, _initialPosition) > maxDragDistance)
        {
            newPosition = Vector3.MoveTowards(_initialPosition, newPosition,  maxDragDistance);
        }
            
        transform.position = newPosition;

        

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CollisionTag")
        {
            audioPlayer.Play();
        }
    }


}
