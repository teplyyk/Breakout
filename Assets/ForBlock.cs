using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBlock : MonoBehaviour
{
    Vector3 Veloсity = GameSettings.BallStartingVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        GameSettings.Score += 1;
    }
}
