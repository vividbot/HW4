using UnityEngine;

public class Pipe : MonoBehaviour
{
    
    
    [SerializeField] float scrollSpeed = 5.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggerEntered");
        if (other.CompareTag("RemovalZone"))
        {
            Destroy(gameObject);
            Debug.Log("PipeRemoved");
        }
    }
}
