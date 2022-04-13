using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public ButtonManager actualButton;
    [SerializeField] float velocidad;
    [SerializeField] SpriteRenderer m_sprite;
    Rigidbody2D m_rb;
    void Start()
    {
        m_rb = this.GetComponent<Rigidbody2D>();
        m_sprite = this.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (actualButton != null)
        {
            if (actualButton.estado < 0)
            {
                m_sprite.flipX = true;
            }
            else 
            {
                m_sprite.flipX = false;
            }

            transform.position += new Vector3(actualButton.estado*Time.deltaTime*velocidad, 0, 0);
        }
    }

    public void RecibioDanio() 
    {
        StartCoroutine(normalColorAfterDanio());
    }

    IEnumerator normalColorAfterDanio() 
    {
        m_sprite.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        m_sprite.color = Color.white;
    }

}
