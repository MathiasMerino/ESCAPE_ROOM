using UnityEngine;
using TMPro;
using System.Collections;

public class ObjetoPista : MonoBehaviour
{
    public string mensaje = "Pista: la llave está escondida cerca de la ventana.";

    public TextMeshProUGUI textoPista;
    public float duracion = 4f;

    private Coroutine rutinaPista;

    public void MostrarPista()
    {
        Debug.Log(mensaje);

        if (textoPista != null)
        {
            if (rutinaPista != null)
            {
                StopCoroutine(rutinaPista);
            }

            rutinaPista = StartCoroutine(MostrarMensaje());
        }
    }

    IEnumerator MostrarMensaje()
    {
        textoPista.text = mensaje;
        textoPista.gameObject.SetActive(true);

        yield return new WaitForSeconds(duracion);

        textoPista.gameObject.SetActive(false);
        rutinaPista = null;
    }
}