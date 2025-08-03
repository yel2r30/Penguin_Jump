using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    [SerializeField] private string m_sceneManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(m_sceneManager);
    }
}
