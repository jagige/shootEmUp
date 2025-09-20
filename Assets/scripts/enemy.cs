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
        transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        
    }
}
