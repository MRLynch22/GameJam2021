using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private Rigidbody _rb;

    public float moveSpeed;

    private Vector3 _playerDir;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {

            ReadInput();
            MoveBall();


    }
    void ReadInput()
    {
        Vector2 move = Vector2.zero;
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        _playerDir = new Vector3(move.x, 0, move.y);

    }
    void MoveBall()
    {
        _rb.AddForce(_playerDir * moveSpeed, ForceMode.Force);
    }
}
