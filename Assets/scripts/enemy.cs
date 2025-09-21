using UnityEngine;

public class enemy : MonoBehaviour
{
    public int life;
    public float speed;
    public int attack;

    public GameObject explosionPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("disparoPlayer"))
        {
            GameObject clonExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(clonExplosion, 0.5f);
            Destroy(gameObject);
        }
    }
}
