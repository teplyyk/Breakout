using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
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
		if (GameSettings.IsGameRunning == false)
		{
			Rect rect = new Rect(
				Screen.width / 4,
				Screen.height / 4,
				Screen.width / 2,
				Screen.height / 2);

			GUI.Box(rect, "Game Over");
		}
	}
    private void OnCollisionEnter2D(Collision2D collision)
	{
        var tag = collision.gameObject.tag;
        if (tag == "wall")
        {
            Veloсity.x = -Veloсity.x;
        }
		else if (tag != "floor")
		{
            if (tag == "paddle")
			{
				float Center = collision.gameObject.transform.position.x;
				float Contact = collision.GetContact(0).point.x;
				float Width = collision.gameObject.transform.localScale.x;
                float RelativeContact = (Center - Contact) / Width;
				if (RelativeContact > 0.8)
				{
					Veloсity.x += 1;
				}
				else if (RelativeContact < 0.2)
                {
                    Veloсity.x -= 1;
                }



            }
            Veloсity.y = -Veloсity.y;
		}
    }


    private void OnTriggerEnter2D(Collider2D collision)
	{
		var tag = collision.gameObject.tag;
		
		if (tag == "floor")
		{
			GameSettings.IsGameRunning = false;
        }
	}
}
