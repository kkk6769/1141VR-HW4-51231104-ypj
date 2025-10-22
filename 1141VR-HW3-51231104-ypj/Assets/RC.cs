using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;           // 旋轉速度
    float deceleration = 0.1f;     // 每幀減速量

    void Start()
    {
        Application.targetFrameRate = 60; // 設定畫面更新率為 60 FPS
    }

    void Update()
    {
        // 點擊滑鼠左鍵啟動轉盤（使用新 Input System）
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            rotSpeed = Random.Range(20f, 30f); // 隨機初始速度
        }

        // 如果速度大於 0，就持續旋轉並減速
        if (rotSpeed > 0)
        {
            transform.Rotate(0, 0, rotSpeed);
            rotSpeed -= deceleration;

            // 防止速度變成負值
            if (rotSpeed < 0)
            {
                rotSpeed = 0;
            }
        }
    }
}
