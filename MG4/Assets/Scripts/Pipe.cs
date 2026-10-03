using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
