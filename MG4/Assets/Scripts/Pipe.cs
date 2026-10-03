using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
