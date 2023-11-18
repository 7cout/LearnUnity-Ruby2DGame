using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{   
    private Rigidbody2D _rigidbody2d;
    private float _horizontal;
    private float _vertical;
    private int _currentHealth;

    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();

        _currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 position = _rigidbody2d.position;
        position.x = position.x + 3f * _horizontal * Time.deltaTime;
        position.y = position.y + 3f * _vertical * Time.deltaTime;
        _rigidbody2d.MovePosition(position);
    }

    void ChangeHealth( int amount )
    {
        _currentHealth = Mathf.Clamp(_currentHealth + amount, 0, maxHealth);
        Debug.Log(_currentHealth + "/" + maxHealth);
    }
}
