using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Canvas_Introduction;
    public GameObject Canvas_Selection;
    public GameObject Dragon_Selection;
    public Image Dragon;
    public Sprite Dragon1;
    public Sprite Dragon2;
    public Sprite Dragon3;

    public GameObject DragonSelected1;
    public GameObject DragonSelected2;
    public GameObject DragonSelected3;

    public int selectionable = 1;

    void Start()
    {

    }

    // Start is called before the first frame update
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
        if (direction == "L")
        {
            selectionable = selectionable - 1;
            if (selectionable <= 1)
            {
                selectionable = 1;
            }
            switch (selectionable)
            {
                case 1:
                    Dragon.sprite = Dragon1;
                    DragonSelected1.SetActive(true);
                    DragonSelected2.SetActive(false);
                    DragonSelected3.SetActive(false);
                    break;

                case 2:
                    Dragon.sprite = Dragon2;
                    DragonSelected1.SetActive(false);
                    DragonSelected2.SetActive(true);
                    DragonSelected3.SetActive(false);
                    break;

                case 3:
                    Dragon.sprite = Dragon3;
                    DragonSelected1.SetActive(false);
                    DragonSelected2.SetActive(false);
                    DragonSelected3.SetActive(true);
                    break;

                // Agrega más casos según sea necesario

                default:
                    // Manejo para el caso en que selectionable no coincida con ningún caso.
                    break;
            }
        }
        else
        {
            selectionable = selectionable + 1;
            if (selectionable >= 3)
            {
                selectionable = 3;
            }

            switch (selectionable)
            {
                case 1:
                    Dragon.sprite = Dragon1;
                    DragonSelected1.SetActive(true);
                    DragonSelected2.SetActive(false);
                    DragonSelected3.SetActive(false);
                    break;

                case 2:
                    Dragon.sprite = Dragon2;
                    DragonSelected1.SetActive(false);
                    DragonSelected2.SetActive(true);
                    DragonSelected3.SetActive(false);
                    break;

                case 3:
                    Dragon.sprite = Dragon3;
                    DragonSelected1.SetActive(false);
                    DragonSelected2.SetActive(false);
                    DragonSelected3.SetActive(true);
                    break;

                // Agrega más casos según sea necesario

                default:
                    // Manejo para el caso en que selectionable no coincida con ningún caso.
                    break;
            }
        }

        Debug.Log("El valor esta en " + selectionable);
    }

}
