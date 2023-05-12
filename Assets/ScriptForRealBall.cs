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
		Rect rect = new Rect(
			Screen.width / 4,
			Screen.height / 4,
			Screen.width / 2,
			Screen.height / 2);

		GUI.Box(rect, "Game Over");
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
