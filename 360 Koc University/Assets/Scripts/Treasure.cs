using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Treasure : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if(gameObject.tag == "Trophy")
            {
                Debug.Log("Left Mouse Button Clicked on: " + name);
                GameManager.isTrophyCollected = true;
                Debug.Log("Added " + name + " to the inventory.");
                Destroy(gameObject);
            }

            if (gameObject.tag == "Stapler")
            {
                Debug.Log("Left Mouse Button Clicked on: " + name);
                GameManager.isStaplerCollected = true;
                Debug.Log("Added " + name + " to the inventory.");
                Destroy(gameObject);
            }
        }
    }
}
