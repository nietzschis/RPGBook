using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    [HideInInspector]
    public int level;
    [HideInInspector]
    public int experience;
    [HideInInspector]
    public int maxHealthPoint = 10;
    [HideInInspector]
    public int currentHealthPoint = 10;
    [HideInInspector]
    public int strength = 1;
    [HideInInspector]
    public int luck = 1;
    [HideInInspector]
    public int stamina = 1;

    private void Start()
    {
        level = 1;

    }



}
