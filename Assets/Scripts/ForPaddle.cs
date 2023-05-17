using UnityEngine;

public class ForPaddle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        HandleMovementUp();
        HandleMovementDown();
    }

    void HandleMovementUp()
    {
        Vector3 Vec = transform.localPosition;

        if (Input.GetKey(KeyCode.D))
            Vec.x += GameSettings.PaddleSpeed * Time.deltaTime;

        if (Vec.x > GameSettings.PaddleRightMargin)
            Vec.x = GameSettings.PaddleRightMargin;

        transform.localPosition = Vec;
    }

    void HandleMovementDown()
    {
        Vector3 Vec = transform.localPosition;

        if (Input.GetKey(KeyCode.A))
            Vec.x -= GameSettings.PaddleSpeed * Time.deltaTime;

        if (Vec.x < -GameSettings.PaddleRightMargin)
            Vec.x = -GameSettings.PaddleRightMargin;

        transform.localPosition = Vec;
    }
}
