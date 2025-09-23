using UnityEngine;

public class enemyMovDestroy : MonoBehaviour
{
    //public GameObject encontrarObjeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //encontrarObjeto = transform.GetChild(0).gameObject;

       // Debug.Log(encontrarObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.Find("naves3-b") == null)
        {
            Destroy(gameObject);
        }

    }
}
