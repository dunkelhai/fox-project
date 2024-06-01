using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    public CharacterController2D characterController;
    public float moveSpeed = 1f;  // Velocidade do movimento
    public float changeDirectionTime = 2f;  // Tempo em segundos para mudar de direção

    private float timer;
    private float direction = 1f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeDirectionTime)
        {
            direction *= -1;  // Inverte a direção
            timer = 0f;  // Reseta o temporizador
        }

        characterController.Move(direction * moveSpeed * Time.deltaTime, false, false);
    }
}
