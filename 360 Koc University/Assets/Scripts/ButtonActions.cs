using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    [SerializeField] Image backgroundImage;

    Color32 greenColor = new Color32(100, 196, 171, 255);
    Color32 redColor = new Color32(193, 11, 37, 255);

    public void RightAnswer()
    {
        backgroundImage.color = greenColor;
    }

    public void WrongAnswer()
    {
        backgroundImage.color = redColor;
    }

}
