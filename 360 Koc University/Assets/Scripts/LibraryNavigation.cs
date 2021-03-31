using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryNavigation : MonoBehaviour
{
    // Holds all the materials for the Entrance scene
    [SerializeField] Material[] libraryMaterials;
    [SerializeField] GameObject[] libraryArrows;

    // Get the sphere called Library
    private GameObject library;

    void Awake()
    {
        // Fetch the Entrance game object
        library = gameObject;
    }

    public void ChangeMaterial(int i)
    {
        Debug.Log("You have clicked the button to change materials.");
        library.GetComponent<MeshRenderer>().material = libraryMaterials[i];
    }
}
