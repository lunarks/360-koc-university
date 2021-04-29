using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource_button : MonoBehaviour
{
   public void  play_sound(int s)
    {
        AudioManager.instance.s_playsound(s);

    }
}
