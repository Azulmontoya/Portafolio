using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject Instruction;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instruction.SetActive(true);
            Debug.Log("Entrada en el trigger con Player");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instruction.SetActive(false);
            Debug.Log("Salida del trigger con Player");
        }
    }
}
