using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusScript : MonoBehaviour
{
    public float hiz;
    public float ziplamaGucu;
    public int puan;
    public GameObject canvas;
    public AudioClip[] sesDosyalari;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
        puan = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * hiz * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);
        }
    }

    void OnTriggerExit2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Tetik")
        {
            Debug.Log("Dad");
            puan++;
            temas.gameObject.transform.parent.gameObject.transform.parent.gameObject.GetComponent<Patika>().temasEdildimi = true;
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[2], 1);

        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Engel")
        {
            Debug.Log("engel");
            OyunSonu();
        }
    }

    void OyunSonu()
    {
        canvas.SetActive(true);
        Time.timeScale = 0;
        GetComponent<AudioSource>().PlayOneShot(sesDosyalari[1], 1);
    }

    public void TekrarButton()
    {
        Application.LoadLevel("Test");
    }
}
