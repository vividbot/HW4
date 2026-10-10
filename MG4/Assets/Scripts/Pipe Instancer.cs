using UnityEngine;

public class PipeInstancer : MonoBehaviour
{
    private float pipeSpawnRate;

    [SerializeField] private GameObject pipeToSpawn;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pipeSpawnRate = 0f;
        Locator.Instance.gameOver += HandlePlayerGameOver;

    }

    // Update is called once per frame
    void Update()
    {
        pipeSpawnRate -= Time.deltaTime;

        Vector3 spawnPointRand = new Vector3(10.0f, Random.Range(3.0f, -3.0f), 0.0f);

        if(pipeSpawnRate <= 0)
        {
            Instantiate(pipeToSpawn, spawnPointRand, Quaternion.identity);
            pipeSpawnRate = 5.0f;
        }

    }
    public void HandlePlayerGameOver()
    {
        Debug.Log("Pipes Turned off!");
        Destroy(gameObject);
    }


}
