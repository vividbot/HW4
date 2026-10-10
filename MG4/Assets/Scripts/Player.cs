using UnityEngine;

public class PlayerController : MonoBehaviour
{


    //Player control stuff
    [SerializeField] float jumpHeight = 4.0f;
    private Rigidbody2D rb;

    [SerializeField] private AudioSource jumpSound;

    private void Jump()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight);
            jumpSound.Play();


        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
 
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipe"))
        {
            // Debug.Log("point scored");
            Locator.Instance.ScorePoint(1);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            // Debug.Log("you Died");
            Locator.Instance.endGame();
            Destroy(gameObject);
        }
    }

}


// 
