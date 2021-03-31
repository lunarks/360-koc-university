using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryNavigation : MonoBehaviour
{
    // Holds all the materials for the Entrance scene
    [SerializeField] Material[] libraryMaterials;

    // Get the sphere called Library
    private GameObject library;

    void Awake()
    {
        // Fetch the Entrance game object
        library = gameObject;
    }

    public void ChangeMaterial(int i)
    {
        library.GetComponent<MeshRenderer>().material = libraryMaterials[i];
    }
}
