using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Character m_character;
    Animator anim;
    void Start()
    {
        m_character = this.GetComponent<Character>();
        anim = this.GetComponent<Animator>();
    }
    void Update()
    {
        if (m_character.actualButton != null)
        {
            anim.SetBool("running", true);
        }
        else 
        {
            anim.SetBool("running", false);
        }
    }
}
