using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surucu : MonoBehaviour
{
    [SerializeField] float hareketHizi = 8f;
    [SerializeField] float direksiyonAcisi = 120;
   
    void Start()
    {
        
    }

    
    void Update()
    {

        float direksiyonDegeri = Input.GetAxis("Horizontal") * direksiyonAcisi * Time.deltaTime;
        float hareketDegeri = Input.GetAxis("Vertical") * hareketHizi * Time.deltaTime;

        transform.Rotate(0, 0, -direksiyonDegeri);
        transform.Translate(0, hareketDegeri, 0);

    }
}
