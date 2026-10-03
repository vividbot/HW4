using UnityEngine;

public class PlayerController : MonoBehaviour
{


    //Player control stuff
    [SerializeField] float jumpHeight = 4.0f;
    private Rigidbody2D rb;



    private void Jump()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight);

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

}
