using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{

    public static Puntuacion instance;

    [SerializeField]
    TextMeshProUGUI puntos;

    [SerializeField]
    int puntosJugador1 = 0;

    [SerializeField]
    int puntosJugador2 = 0;

    [SerializeField]
    GameObject screenVictoriaJugador1;

    [SerializeField]
    GameObject screenVictoriaJugador2;


    private void Awake()
    {
        if (Puntuacion.instance == null)
        {
            Puntuacion.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        screenVictoriaJugador1.SetActive(false);
        screenVictoriaJugador2.SetActive(false);

        ActualizarPuntuacion();
    }

    public void GolesJugador1()
    {
        puntosJugador1++;
        ActualizarPuntuacion();
    }

    public void GolesJugador2()
    {
        puntosJugador2++;
        ActualizarPuntuacion();
    }

    public void ActualizarPuntuacion()
    {
        puntos.text = puntosJugador1.ToString() + " : " + puntosJugador2.ToString();
    }

    public void Victoria()
    {
        if (puntosJugador1 == 3)
        {
            screenVictoriaJugador1.SetActive(true);
        }

        if (puntosJugador2 == 3)
        {
            screenVictoriaJugador2.SetActive(true);
        }
    }
}
