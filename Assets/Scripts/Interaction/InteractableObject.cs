using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public void Interact()
    {
        Debug.Log("Objeto recogido: " + gameObject.name);
        gameObject.SetActive(false);
    }
}