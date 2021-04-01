using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Treasure : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
