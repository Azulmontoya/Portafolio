using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Canvas_Introduction;
    public GameObject Canvas_Selection;
    public GameObject Dragon_Selection;
    public Image Dragon;
    public Sprite[] dragonSprites;  // Usamos un array para almacenar los sprites
    public GameObject[] dragonSelectedObjects;  // Usamos un array para almacenar los objetos DragonSelected
    public int selectionable = 0;  // Cambié el valor inicial para que pueda ser 0, 1, 2, 3

    void Start()
    {

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
}
