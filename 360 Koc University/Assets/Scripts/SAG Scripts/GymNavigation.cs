using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymNavigation : MonoBehaviour
{
    // Holds all the materials for the Gym scene
    [SerializeField] Material[] gymMaterials;

    private GameObject gym;

    void Awake()
    {
        // Fetch the Entrance game object
        gym = gameObject;
    }

    public void ChangeMaterial(int i)
    {
        gym.GetComponent<MeshRenderer>().material = gymMaterials[i];
    }
}
