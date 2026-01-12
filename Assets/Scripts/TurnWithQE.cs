using UnityEngine;

public class TurnWithQE : MonoBehaviour
{
    public float turnSpeed = 120f; // 每秒旋轉角度

    void Update()
    {
        float dir = 0f;

        if (Input.GetKey(KeyCode.Q)) dir = -1f; // 左轉
        if (Input.GetKey(KeyCode.E)) dir = 1f; // 右轉

        transform.Rotate(0f, dir * turnSpeed * Time.deltaTime, 0f);
    }
}
