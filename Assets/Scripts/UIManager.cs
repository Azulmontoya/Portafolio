using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject Canvas_Introduction;
    public GameObject Canvas_Selection;
    public GameObject Dragon_Selection;
    public Image Dragon;
    public Sprite[] dragonSprites;  // Usamos un array para almacenar los sprites
    public GameObject[] dragonSelectedObjects;  // Usamos un array para almacenar los objetos DragonSelected
    public int selectionable = 0;  // Cambié el valor inicial para que pueda ser 0, 1, 2, 3
    public int selectionableLevel = 3;
    void Start()
    {
        // Obtén la instancia del Singleton
        SingletonManager singletonManager = SingletonManager.Instancia;
        // Lee el valor de la propiedad 'selection' del Singleton y asígnalo a 'selectionable'
        selectionableLevel = singletonManager.selection;
        if(selectionableLevel != 3 ){
           Canvas_Introduction.SetActive(false);
           Canvas_Selection.SetActive(false);
           Dragon_Selection.SetActive(true);
        }
    }

    public void Selection()
    {
        Canvas_Selection.SetActive(true);
        Canvas_Introduction.SetActive(false);
    }

    public void SelectDragon()
    {
        Dragon_Selection.SetActive(true);
        Canvas_Selection.SetActive(false);
    }

    public void Carousel(string direction)
    {
        int previousSelection = selectionable;

        if (direction == "L")
        {
            selectionable = Mathf.Max(selectionable - 1, 0);
        }
        else
        {
            selectionable = Mathf.Min(selectionable + 1, dragonSprites.Length - 1);
        }

        if (selectionable != previousSelection)
        {
            UpdateDragonSelection();
        }

        Debug.Log("El valor está en " + selectionable);
    }

    void UpdateDragonSelection()
    {
        Dragon.sprite = dragonSprites[selectionable];

        for (int i = 0; i < dragonSelectedObjects.Length; i++)
        {
            dragonSelectedObjects[i].SetActive(i == selectionable);
        }
    }

    public void SelectScene()
    {
        switch (selectionable)
        {
            case 0:
                SceneManager.LoadScene("Level_Dragon_Fire");
                break;
            case 1:
                SceneManager.LoadScene("Level_Dragon_Snow");
                break;
            default:
                SceneManager.LoadScene("Level_Dragon_Rock");
                break;
        }
    }
}
