using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartLevel() {
        print("test");
        Scene scene1 = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene1.name);
    }
}
