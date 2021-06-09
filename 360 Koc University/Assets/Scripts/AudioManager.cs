using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioManager instance;

    public AudioClip[] s_audiolist;

    List<AudioSource> s_source = new List<AudioSource>();

   


    void Start()
    {
        instance = this;
        for (int i = 0; i < s_audiolist.Length; i++)
        {
            s_source.Add(new AudioSource());
            s_source[i] = gameObject.AddComponent<AudioSource>();
            s_source[i].clip = s_audiolist[i];
        }
    }

    public void s_playsound(int s)
    {
        s_source[s].Play();
    }

    public void s_stopsound(int s)
    {
        s_source[s].Stop();
    }
}
        
    

    
