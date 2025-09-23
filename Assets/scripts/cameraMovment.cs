using UnityEngine;
using UnityEngine.Rendering;

public class cameraMovment : MonoBehaviour
{
    [SerializeField] int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 117)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (speed * Time.deltaTime), transform.position.z);
        }
        

    }

   
}
