using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 25f;

    private bool _isGrounded;
    private Rigidbody2D _rigidbody;

        void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButton(0) && _isGrounded)
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            if (PlayerCollisions.CollideWithSide(gameObject, other.gameObject, PlayerCollision.Side.Bottom))
            {
                _isGrounded = true;
            }
            else
            {
                GameManager.EndGame();
            }
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.EndGame();
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {

    }
    void OnCollisionStay2D(Collision2D other)
    {

    }

}
   
    
