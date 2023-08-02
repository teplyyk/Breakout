using UnityEngine;

public class GameSettings
{
    public static float PaddleSpeed = 20.0f;
    public static float PaddleRightMargin = 15.24f;
    public static int Score = 0;
    public static Vector3 BallStartingVelocity = new Vector3(-5.0f, -5.0f, 0.0f);
    public static Vector3 BonusVelocity = new Vector3(0.0f, -10.0f, 0.0f);
    public static bool IsGameRunning = true;
}
