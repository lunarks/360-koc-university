using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateGymX : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SAG" && GameObject.Find("Trophy") == null)
        {
            Destroy(gameObject);
        }
    }
}
