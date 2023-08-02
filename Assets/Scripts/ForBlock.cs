using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBlock : MonoBehaviour
{
    Vector3 Veloсity = GameSettings.BallStartingVelocity;
    public GameObject effect;
    public GameObject bonus;
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
        Instantiate(bonus, transform.position, Quaternion.identity);
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameSettings.Score += 1;
    }
}
