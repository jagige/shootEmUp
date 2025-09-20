using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    public GameObject disparoPlayerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            Instantiate(disparoPlayerPrefab);
        }
        if (Gamepad.current != null)
        {
            if (Gamepad.current.bButton.wasPressedThisFrame) 
            {
                Instantiate(disparoPlayerPrefab);
            }
        }
    }
    private void OnMove(InputValue inputValue)
    {
        Vector2 move = inputValue.Get<Vector2>();
        _rb.linearVelocity = move * _speed;
    }

    private void OnAttack()
    {
        Debug.Log("Se ejecutó On attack");
    }
}
