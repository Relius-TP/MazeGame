using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene1 : MonoBehaviour
{
    public void Scene2()
    {
        SceneManager.LoadScene("Scene 1");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene2();
    }
}
