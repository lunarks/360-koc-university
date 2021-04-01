using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateLibraryX : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SKL" && GameObject.Find("Stapler") == null)
        {
            Destroy(gameObject);
        }
    }
}
