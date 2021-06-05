using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField]
    string name;

    [TextArea]
    [SerializeField]
    string description;

    [SerializeField]
    Sprite frontSprite;

    [SerializeField]
    Sprite backSprite;

    [SerializeField]
    PokemonType type1;

    [SerializeField]
    PokemonType type2;

    // Base Stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defence;
    [SerializeField] int spAttack;
    [SerializeField] int spDefence;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMoves> learnableMoves;

    // public getters
    public string Name => name;
    public string Description => description;
    public Sprite FrontSprite => frontSprite;
    public Sprite BackSprite => backSprite;
    public PokemonType Type1 => type1;
    public PokemonType Type2 => type2;
    public int MaxHp => maxHp;
    public int Attack => attack;
    public int Defence => defence;
    public int SpAttack => spAttack;
    public int SpDefence => spDefence;
    public int Speed => speed;

    public List<LearnableMoves> LearnableMoves => learnableMoves;

}

[Serializable]
public class LearnableMoves
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase MoveBase => moveBase;
    public int Level => level;
}

public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
}
