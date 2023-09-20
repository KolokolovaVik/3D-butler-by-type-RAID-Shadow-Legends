using UnityEngine;

public sealed class Player : MonoBehaviour
{
    private static readonly int State = Animator.StringToHash("State");
    private static readonly int FistAttack = Animator.StringToHash("FistAttack");
    private static readonly int Death = Animator.StringToHash("Death");
    private const int _moveAnimState = 1;
    private const int _idleAnimState = 0;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Animator _enemyAnimator;

    private bool _isMoving;
    private Vector3 _moveDirection;

    public void Move(Vector3 direction)
    {
        _isMoving = true;
        _moveDirection = direction;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            _animator.SetTrigger(FistAttack);
            _enemyAnimator.SetTrigger(Death);
        }
    }

    private void FixedUpdate()
    {
        if (_isMoving)
        {
            UpdateMovement();
            _animator.SetInteger(State, _moveAnimState);
            _isMoving = false;
        }
        else
        {
            _animator.SetInteger(State, _idleAnimState);
        }
    }

    private void UpdateMovement()
    {
        var deltaTime = Time.fixedDeltaTime;
        transform.position += _moveDirection * _moveSpeed * deltaTime;

        var targetRotation = Quaternion.LookRotation(_moveDirection, Vector3.up);
        var nextRotation = Quaternion.Slerp(transform.rotation, targetRotation, _rotationSpeed * deltaTime);
        transform.rotation = nextRotation;
    }
}
