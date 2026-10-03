using UnityEngine;

public class Locator : MonoBehaviour
{
    
    
        //Event System for scoring a point
    public delegate void IntScored(int x);
    public event IntScored PointsChanged;

    //Event system for Colliding with a pipe
    public delegate void PlayerCollided();
    public event PlayerCollided gameOver;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
