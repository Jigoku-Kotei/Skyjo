using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Card/Score")]
public class CardScore : ScriptableObject
{
    [SerializeField] int score;
}
