using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2d;
    private float _horizontal;
    private float _vertical;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
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
}
