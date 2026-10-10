using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI uiText; 
    private int pointCounter;
    [SerializeField] private GameObject gameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
        uiText.text = "Points - 0";
        pointCounter = 0;
        Locator.Instance.PointsChanged += HandlePlayerEarnedPoint;
        Locator.Instance.gameOver += HandlePlayerGameOver;

    }

    private void HandlePlayerEarnedPoint(int x)
    {
        Debug.Log("Earned one point!");
        pointCounter += x;
        Debug.Log("Current Score - " + pointCounter);
        uiText.text = "Points - " + pointCounter;


        
    }
    public void HandlePlayerGameOver()
    {
        Debug.Log("Game Over!!");
        gameOverScreen.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
