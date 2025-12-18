using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    [SerializeField]
    float velocidadPelota = 4f;
    
    [SerializeField]
    Vector3 direccion;
   
    Vector3 origen;    

    private void Awake()
    {
        origen = transform.position;
    }

    void Start()
    {
        EstablecerDireccion();        
    }

    void Update()
    {
        transform.position += direccion.normalized * Time.deltaTime * velocidadPelota;
    }

    public void EstablecerDireccion()
    {
        direccion.x = Random.Range(-1, 2);
        while (direccion.x == 0)
        {
            direccion.x = Random.Range(-1, 2);
        }

        direccion.y = Random.Range(-1, 2);
        while (direccion.y == 0)
        {
            direccion.y = Random.Range(-1, 2);
        }
    }

    public void EstablecerPosicion()
    {
        Vector3 posicionInicial = origen;
    }

    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.CompareTag("Jugador"))
        {
            direccion.x = - direccion.x;
        }
        else if (collision.gameObject.CompareTag("Pared"))
        {
            direccion.y = - direccion.y;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        transform.position = origen;
        
        EstablecerDireccion();

        if(other.CompareTag("Derecha"))
        {
            Puntuacion.instance.GolesJugador1();
        }
        
        if(other.CompareTag("Izquierda"))
        {
            Puntuacion.instance.GolesJugador2();
        }
    }
}
