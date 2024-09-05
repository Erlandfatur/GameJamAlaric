using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator _animator;
    
    // Parameter IDs
    private int _animIDMove;

    private void Awake()
    {
        // Get the Animator component
        _animator = GetComponent<Animator>();

        // Initialize parameter IDs
        _animIDMove = Animator.StringToHash("Move");
    }

    public void SetMoveAnimation(bool isMoving)
{
    // Debugging
    Debug.Log($"Setting Move Animation: {isMoving}");
    
    // Set the Move parameter in the Animator
    _animator.SetBool(_animIDMove, isMoving);
}

}
