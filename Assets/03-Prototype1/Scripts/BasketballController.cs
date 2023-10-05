using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballController : MonoBehaviour
{
    public float MoveSpeed = 10;
    public Transform Ball;
    public Transform Arms;
    public Transform PosOverHead;
    public Transform PosDribble;

    private bool InBallInHands = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position += direction * MoveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + direction);

        if (InBallInHands)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Ball.position = PosOverHead.position;
            }

            else
            {
                Ball.position = PosDribble.position;
            }
        }
    }
}
