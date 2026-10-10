using UnityEngine;

public class Audio : MonoBehaviour
{


    [SerializeField] private AudioSource coinSound;
    [SerializeField] private AudioSource gameOverSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Locator.Instance.PointsChanged += HandlePlayerEarnedPoint;
        Locator.Instance.gameOver += HandlePlayerGameOver;

    }

    private void HandlePlayerEarnedPoint(int x)
    {
        coinSound.Play();
        // Debug.Log("Earned one point!");
    }
    public void HandlePlayerGameOver()
    {
        gameOverSound.Play();
        // Debug.Log("Game Over!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
