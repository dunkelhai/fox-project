using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.SceneManagement;

public class cena1 : MonoBehaviour
{
    public string nextLevelName = "Fase1"; // Nome da próxima fase

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fox"))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}

