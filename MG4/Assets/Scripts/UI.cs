using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Locator.Instance.PointsChanged += HandlePlayerEarnedPoint;
        Locator.Instance.gameOver += HandlePlayerGameOver;

    }

    private void HandlePlayerEarnedPoint(int x)
    {
        Debug.Log("Earned one point!");
    }
    public void HandlePlayerGameOver()
    {
        Debug.Log("Game Over!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
