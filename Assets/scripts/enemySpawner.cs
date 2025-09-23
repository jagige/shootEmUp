using UnityEngine;
using UnityEngine.InputSystem;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyNave2Prefab;
    public float timeToSpawn;
    public float randomRango1;
    public float randomRango2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if(timeToSpawn <= 0)
        {
            var enemySpawner = Instantiate(enemyNave2Prefab, transform.position, Quaternion.identity);
            timeToSpawn = 2;

            enemy enemyComponent = enemySpawner.GetComponent<enemy>();

            float randomSpeed = Random.Range(randomRango1, randomRango2);

            enemyComponent.speed = randomSpeed;
        }

        //if (Keyboard.current.pKey.wasPressedThisFrame)
        //{
        //    Instantiate(enemyNave2Prefab);
        //}
    }
}
