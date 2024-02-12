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
    {   //dodaj do wspó³rzêdnych wartoœæ x=1,y=0 z=0 pomno¿one przez czas w s 
        // mierzony w sekundach od ostatniej klatki //test //teseeee
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        //prezentacja dzia³ania wyg³adzonego sterowania (emulacja joysticka)
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie prêdkoœci¹:
        //stwórz nowy wektor przesuniêcia o wartoœci 1 do przodu
        Vector3 movement = Vector3.forward;
        //pomnó¿ go przez czas od ostatniej klatki
        movement *= Time.deltaTime;
        //pomnó¿ go przez "wychylenie joysticka"
        movement *= Input.GetAxis("Vertical");
        //dodaj ruch do obiektu
        transform.position += movement;

        //obrót
        //modyfikuj oœ "Y" obiektu player

        Vector3 rotation = Vector3.up;
        rotation *= Time.deltaTime;
        rotation *= Input.GetAxis("Horizontal");
        // pomnó¿ prez prêdkoœæ obrotu 
        rotation *= rotationSpeed;
        //dodaj obrót do obiektu
        // nie mo¿emy u¿yæ += poniewa¿ unity mo¿e uzywa Quaternionów do zapisu rotacji
        transform.Rotate(rotation);
        
    }
}
