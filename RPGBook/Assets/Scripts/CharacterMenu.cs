using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour {

    [SerializeField]
    Text levelText;

    CharacterStats characterStats;

    private void Start()
    {
        characterStats = GetComponent<CharacterStats>();
    }

    public void setupMenu()
    {
        levelText.text = characterStats.level.ToString();
    }
}
