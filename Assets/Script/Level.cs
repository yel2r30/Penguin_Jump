using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
        public void LoadStage(string stageName)
        {
            SceneManager.LoadScene(stageName);
        }
}
