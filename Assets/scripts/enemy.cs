using UnityEngine;

public class enemy : MonoBehaviour
{
    public int life;
    public float speed;
    public int attack;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (1 * Time.deltaTime), transform.position.y);
        
    }
}
