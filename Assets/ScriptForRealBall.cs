using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForRealBall : MonoBehaviour
{
    Vector3 Veloсity = GameSettings.BallStartingVelocity;

    void FixedUpdate()
    {
        transform.Translate(Veloсity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //var tag = collision.gameObject.tag;
        //if (tag == "wall")
        //{
        //}

        Veloсity.y = -Veloсity.y;
    }
}
