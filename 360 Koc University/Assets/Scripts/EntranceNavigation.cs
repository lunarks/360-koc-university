using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceNavigation : MonoBehaviour
{
    // Holds all the materials for the Entrance scene
    [SerializeField] Material[] entranceMaterials;

    private GameObject entrance;

    // Start is called before the first frame update
    void Awake()
    {
        // Fetch the Entrance game object
       entrance = GameObject.Find("Entrance");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial(int i)
    {
        Debug.Log("You have clicked the button to change materials.");
        entrance.GetComponent<MeshRenderer>().material = entranceMaterials[i];
    }
}
