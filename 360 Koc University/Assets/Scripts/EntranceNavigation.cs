using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceNavigation : MonoBehaviour
{
    // Holds all the materials for the Entrance scene
    [SerializeField] Material[] entranceMaterials;
    [SerializeField] GameObject[] entranceArrows;

    private GameObject entrance;

    void Awake()
    {
        // Fetch the Entrance game object
        entrance = gameObject;
    }

    public void ChangeMaterial(int i)
    {
        Debug.Log("You have clicked the button to change materials.");
        entrance.GetComponent<MeshRenderer>().material = entranceMaterials[i];
        if (i == 1)
        {
            entranceArrows[0].SetActive(false);
            entranceArrows[1].SetActive(true);
        }
        else if (i == 0)
        {
            entranceArrows[0].SetActive(true);
            entranceArrows[1].SetActive(false);
        }
    }
}
