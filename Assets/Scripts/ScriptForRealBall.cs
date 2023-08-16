using Coherence.Connection;
using Coherence.Toolkit;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static GameSettings;

public class ScriptForRealBall : MonoBehaviour
{
    public void ChangeStateToGameOver()
    {
        GameState = EGameState.GameOver;
        
    }
    public enum EGameState: uint
    {
        Connecting,
        Playing,
        GameOver
    }
    public EGameState GameState = EGameState.Connecting;

Vector3 Veloсity = GameSettings.BallStartingVelocity;
	
	void FixedUpdate()
	{
        if (GameState == EGameState.Playing)
        {
            transform.Translate(Veloсity * Time.deltaTime);
        }
	}
	void OnGUI()
	{
		if (GameState == EGameState.GameOver)
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
                float RelativeContact = (Contact - Center) / Width;

				Veloсity.x += 20 * RelativeContact;
			}
			Veloсity.y = -Veloсity.y;
		}
    }


    private void OnTriggerEnter2D(Collider2D collision)
	{
		var tag = collision.gameObject.tag;

		if (tag == "floor")
		{
            ChangeStateToGameOver();
        }
	}
    public void OnConnect(CoherenceBridge bridge)
    {
        GameState = EGameState.Playing;
    }

    public void OnDisconnect(CoherenceBridge bridge, ConnectionCloseReason reason)
    {
        GameState = EGameState.GameOver;
    }

}
