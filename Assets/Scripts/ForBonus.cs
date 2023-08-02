using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBonus : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(GameSettings.BonusVelocity * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var tag = collision.gameObject.tag;

        if (tag == "paddle")
        {
            collision.gameObject.transform.localScale += new Vector3(0.5f , 0.0f, 0.0f);
        }
    }
}
