using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0.00f, 10.00f)] private float _moveSpeed = 0.00f;
    public float MoveSpeed => _moveSpeed * 100.00f;

    private float _horizontalInput = 0.00f;
    private Rigidbody2D _rigidbody2D = null;

    private void Awake() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        _rigidbody2D.freezeRotation = true;
    }

    private void Update() {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() {
        _rigidbody2D.velocity = new Vector2(_horizontalInput * Time.fixedDeltaTime * MoveSpeed, _rigidbody2D.velocity.y);
    }
}