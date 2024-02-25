using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public GameObject instruction;

    // Start is called before the first frame update
    public void Return()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void Scene1()
    {
        SceneManager.LoadScene("Level_Dragon_Fire");
    }

    public void ShowInstructions()
    {
        // Verificar el estado actual del objeto instruction
        bool currentState = instruction.activeSelf;

        // Cambiar entre true y false
        instruction.SetActive(!currentState);
    }
}
