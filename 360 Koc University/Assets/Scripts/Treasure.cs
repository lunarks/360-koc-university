using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Treasure : MonoBehaviour, IPointerClickHandler
{
    public GameObject gameManager;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left Mouse Button Clicked on: " + name);
            gameManager.GetComponent<GameManager>().isTrophyCollected = true;
            Destroy(gameObject);
        }
    }
}
