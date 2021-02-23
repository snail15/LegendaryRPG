using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField]
    [Range(1f,5f)]
    private float _moveSpeed;

    [SerializeField] private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * _moveSpeed;

        _animator.SetFloat("moveX", _rigidbody2D.velocity.x);
        _animator.SetFloat("moveY", _rigidbody2D.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == -1 || Input.GetAxisRaw("Vertical") == 1)
        {
            _animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            _animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }


    }
}
