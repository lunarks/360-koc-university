using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Holds all the materials for the scene
    [SerializeField] Material[] materials;

    // To store the Sphere game object
    private GameObject sphere;

    void Awake()
    {
        // Fetch the Entrance game object
        sphere = gameObject;
    }

    public void ChangeMaterial(int i)
    {
        sphere.GetComponent<MeshRenderer>().material = materials[i];
    }
}