using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class EagleController2D : MonoBehaviour
{
    [SerializeField] private float m_FlySpeed = 2f;     
    [SerializeField] private float m_ChangeDirectionTime = 2f; 

    private Rigidbody2D m_Rigidbody2D;
    private bool m_FacingRight = true;
    private float m_Direction = 1f;
    private float m_Timer;

    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer >= m_ChangeDirectionTime)
        {
            m_Timer = 0f;
            m_Direction *= -1f;  // Inverte a direção
            Flip();
        }

        Vector2 targetVelocity = new Vector2(m_FlySpeed * m_Direction, m_Rigidbody2D.velocity.y);
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

