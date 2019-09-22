using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patika : MonoBehaviour
{
    public bool temasEdildimi;

    public GameObject borular;

    // Start is called before the first frame update
    void Start()
    {
        temasEdildimi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (temasEdildimi)
        {
            Invoke("IleriAta", 2f);
            temasEdildimi = false;
        }
    }

    void IleriAta()
    {
        transform.position = transform.position + new Vector3(6, 0, 0);

        float yPoz = Random.Range(0, 0.79f);
        Debug.Log(yPoz);

        borular.transform.localPosition = new Vector3(1.501095f, yPoz, 0);

    }
}
