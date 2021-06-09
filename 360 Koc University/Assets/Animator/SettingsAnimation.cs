using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsAnimation : MonoBehaviour
{
    public GameObject settingsCanvas;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = settingsCanvas.GetComponent<Animator>();
    }

    public void slideInAnimation()
    {
        animator.SetBool("openSettings", true);
    }

    public void slideOutAnimation()
    {
        animator.SetBool("openSettings", false);
    }
}
