﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardGroup
{
    Spade,
    Club,
    Diamond,
    Heart,
    Length
}

public enum CardNumber
{
    A,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Length
}

public enum CardState
{
    Backface,
    FrontfaceIncorrect,
    FrontfaceCorrect,
    Flipping
}

public enum SoundEffect
{
    CardSelect,
    PairMatch,
    StageComplete,
    PairMismatch
}