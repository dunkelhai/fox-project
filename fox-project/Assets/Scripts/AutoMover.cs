using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    public float moveSpeed = 1f;  // Velocidade do movimento
    public float changeDirectionTime = 2f;  // Tempo para mudar de direção

    private Rigidbody2D m_Rigidbody2D;
    private float timer;
    private float direction = 1f;
    private bool m_FacingRight = true;

    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeDirectionTime)
        {
            direction *= -1;  // Inverte a direção
            timer = 0f;  
            Flip();
        }

        Vector2 targetVelocity = new Vector2(direction * moveSpeed, m_Rigidbody2D.velocity.y);
        m_Rigidbody2D.velocity = targetVelocity;
    }

    private void Flip()
    {
        m_FacingRight = !m_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
