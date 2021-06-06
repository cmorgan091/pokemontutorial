using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pokemon
{
    public PokemonBase Base { get; set; }
    public int Level { get; set; }

    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;
        HP = MaxHp;

        Moves = Base.LearnableMoves
            .Where(x => x.Level <= Level)
            .Select(x => new Move(x.MoveBase))
            .Take(4)
            .ToList();
    }

    public int Attack => Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5;
    public int Defence => Mathf.FloorToInt((Base.Defence * Level) / 100f) + 5;
    public int SpAttack => Mathf.FloorToInt((Base.SpAttack * Level) / 100f) + 5;
    public int SpDefence => Mathf.FloorToInt((Base.SpDefence * Level) / 100f) + 5;
    public int MaxHp => Mathf.FloorToInt((Base.MaxHp * Level) / 100f) + 10;
}
