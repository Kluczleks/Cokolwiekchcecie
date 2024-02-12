using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //dodaj do wsp�rz�dnych warto�� x=1,y=0 z=0 pomno�one przez czas w s 
        // mierzony w sekundach od ostatniej klatki //test //teseeee
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        //prezentacja dzia�ania wyg�adzonego sterowania (emulacja joysticka)
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie pr�dko�ci�:
        //stw�rz nowy wektor przesuni�cia o warto�ci 1 do przodu
        Vector3 movement = Vector3.forward;
        //pomn� go przez czas od ostatniej klatki
        movement *= Time.deltaTime;
        //pomn� go przez "wychylenie joysticka"
        movement *= Input.GetAxis("Vertical");
        //dodaj ruch do obiektu
        transform.position += movement;

        //obr�t
        //modyfikuj o� "Y" obiektu player

        Vector3 rotation = Vector3.up;
        rotation *= Time.deltaTime;
        rotation *= Input.GetAxis("Horizontal");
        // pomn� prez pr�dko�� obrotu 
        rotation *= rotationSpeed;
        //dodaj obr�t do obiektu
        // nie mo�emy u�y� += poniewa� unity mo�e uzywa Quaternion�w do zapisu rotacji
        transform.Rotate(rotation);
        
    }
}
