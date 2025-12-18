using UnityEngine;

public class Jugador : MonoBehaviour
{
    
    [SerializeField]
    float velocidadJugador = 20f;

    [SerializeField]
    KeyCode upInput;

    [SerializeField]
    KeyCode downInput;

    private Vector3 posicionInicial;

    private void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(upInput))
        {
            transform.position += Vector3.up * Time.deltaTime * velocidadJugador;
        }
        else if (Input.GetKey(downInput))
        {
            transform.position += Vector3.down * Time.deltaTime * velocidadJugador;
        }
    }

    public void ResetearPosicion()
    {
        transform.position = posicionInicial;
    }

}
