using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    //wysoko�� gracza
    public float cameraHeight = 10.0f;
    void Start()
    { //pod��cz pozycje gracza do lokalnej zmiennej korzystaj�c z taga 
      //to nie jest zapisane warto�ci jeden raz tylko referencja do obiektu
      //to znaczy, �e player zawsz� b�dzie zawiera� aktualn� pozycj� gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {   //oblicz docelow� pozycje kamery 
        Vector3 targetPosition = player.position + Vector3.up * cameraHeight;
        //p�ynnie przesu� kamer� w kierunku gracza
        // funkcja Vector3.Lerp
        //p�ynnie przechodzi z pozycji pierwszego argumentu do drugiego w czasie trzeciego 
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
