using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    public EagleController2D eagleController;
    public float moveSpeed = 1f;  
    public float changeDirectionTime = 2f;  

    private float timer;
    private float direction = 1f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeDirectionTime)
        {
            direction *= -1;  
            timer = 0f;  
        }

        eagleController.Move(direction * moveSpeed * Time.deltaTime, false, false);
    }
}
