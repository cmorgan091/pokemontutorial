using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pokemon
{
    PokemonBase _base;
    int level;

    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
        HP = _base.MaxHp;

        Moves = _base.LearnableMoves
            .Where(x => x.Level <= level)
            .Select(x => new Move(x.MoveBase))
            .Take(4)
            .ToList();
    }

    public int Attack => Mathf.FloorToInt((_base.Attack * level) / 100f) + 5;
    public int Defence => Mathf.FloorToInt((_base.Defence * level) / 100f) + 5;
    public int SpAttack => Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5;
    public int SpDefence => Mathf.FloorToInt((_base.SpDefence * level) / 100f) + 5;
    public int MaxHp => Mathf.FloorToInt((_base.MaxHp * level) / 100f) + 10;
}
