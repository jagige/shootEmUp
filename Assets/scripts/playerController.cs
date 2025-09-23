using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    public GameObject disparoPlayerPrefab;
    public float timeToShoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        /*if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            Instantiate(disparoPlayerPrefab, transform.position, Quaternion.identity);
        }
        if (Gamepad.current != null)
        {
            if (Gamepad.current.bButton.wasPressedThisFrame) 
            {
                Instantiate(disparoPlayerPrefab, transform.position, Quaternion.identity);
            }
        }*/
    }
    private void OnMove(InputValue inputValue)
    {
        Vector2 move = inputValue.Get<Vector2>();
        _rb.linearVelocity = move * _speed;

       
    }

    private void OnAttack()
    {
       Instantiate(disparoPlayerPrefab, transform.position, Quaternion.identity);
        //Debug.Log("Se ejecutó On attack");
    }

   /* private void LateUpdate()
    {
        _rb.position = new Vector2(Mathf.Clamp(_rb.position.x, -8.05f, 8.05f), _rb.position.y);
    }*/
}
