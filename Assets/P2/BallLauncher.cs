using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public Rigidbody ball;
    public Transform target;

    public float h = 25;
    public float gravity = -18;
    private void Start() {
        ball.useGravity = false;
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
        
    }
    void Launch()
    {
        Physics.gravity = Vector3.up * gravity;
        ball.useGravity =true;
        ball.velocity = CalculateLaunchVelocity();
        print(CalculateLaunchVelocity());
    }

    Vector3 CalculateLaunchVelocity()
    {
        float displacementY = target.position.y - ball.position.y;
        Vector3 displacementXZ = new Vector3(target.position.x - ball.position.x, 0, target.position.z - ball.position.z);

        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * h);
        Vector3 velocityZ = displacementXZ / (Mathf.Sqrt(-2 * h / gravity) + Mathf.Sqrt(2 * (displacementY - h) / gravity));
        return velocityZ + velocityY;
    }
}
