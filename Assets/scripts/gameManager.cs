using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject boss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("JuegoNavecitas");
        }

        if (boss == null)
        {
            SceneManager.LoadScene("JuegoNavecitas");
        }
    }

   

}
