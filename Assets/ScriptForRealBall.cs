using UnityEngine;

public class ScriptForRealBall : MonoBehaviour
{
    Vector3 Veloсity = GameSettings.BallStartingVelocity;

    void FixedUpdate()
    {
        transform.Translate(Veloсity * Time.deltaTime);
    }
    void OnGUI()
    {
        if (GUILayout.Button("Press Me"))
            Debug.Log("Hello!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var tag = collision.gameObject.tag;
        if (tag == "floor")
        {
            // TODO: add game over
        }
        else
        {
            Veloсity.y = -Veloсity.y;
        }
    }
}
