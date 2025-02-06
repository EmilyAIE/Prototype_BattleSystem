using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public InputSystem_Actions inputActions;
    private InputAction m_move;

    private Rigidbody m_rb;

    [Header("Movement Details")]
    [SerializeField] private float m_moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        m_rb = GetComponent<Rigidbody>();  
        
        m_move = inputActions.Player.Move;

        m_move.Enable();
    }

    private void OnDisable()
    {
        m_move.Disable();
    }


    private void Update()
    {
        
    }
}
