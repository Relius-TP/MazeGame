using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene2 : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("Scene 2");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene1();
    }
}
