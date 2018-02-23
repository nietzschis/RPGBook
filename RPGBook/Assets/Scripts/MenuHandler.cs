using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {

    //[SerializeField]
    //RectTransform canvas;
    [SerializeField]
    RectTransform character_panel;
    [SerializeField]
    RectTransform inventory_panel;

    CharacterMenu characterMenu;

    private void Start()
    {
        characterMenu = GetComponent<CharacterMenu>();
        character_panel.gameObject.SetActive(false);
        inventory_panel.gameObject.SetActive(false);
    }
    public void setMenuInactive()
    {
        character_panel.gameObject.SetActive(false);
        inventory_panel.gameObject.SetActive(false);
    }

    public void gotoInventory()
    {
        inventory_panel.gameObject.SetActive(true);
    }

	public void gotoCharacterMenu()
    {
        character_panel.gameObject.SetActive(true);
        characterMenu.setupMenu();
        /*
        RectTransform char_panel = Instantiate(character_panel) as RectTransform;
        char_panel.transform.SetParent(canvas);
        char_panel.transform.localScale = new Vector3(1, 1, 1);
        char_panel.anchoredPosition = new Vector3(0, 0, 0);
        this_char_panel = character_panel;
        */
    }



}
