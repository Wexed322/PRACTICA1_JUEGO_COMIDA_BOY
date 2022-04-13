using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    UI m_Ui;
    public bool malo_;
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
    void Start()
    {
        m_Ui = FindObjectOfType<UI>();
        StartCoroutine(deadCorrutine());
    }

    void Update()
    {

    }
    IEnumerator deadCorrutine() 
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            if (malo_)
            {
                m_Ui.NoComestibleCollision();

                collision.gameObject.GetComponent<Character>().RecibioDanio();

                int direccion = 0;
                if (this.transform.position.x - collision.gameObject.transform.position.x > 0)
                {
                    direccion = -250;
                }
                else 
                {
                    direccion = 250;
                }
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(direccion, 100));
            }
            else 
            {
                m_Ui.ComestibleCollision();
            }

            Destroy(this.gameObject);
        }
    }
}
