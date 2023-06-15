using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialization : MonoBehaviour
{
    [SerializeField] ScriptableObject totalCards;

    [SerializeField] GameObject[] cards;

    [SerializeField] GameObject[] boardSlots;
    [SerializeField] GameObject DeckSlots;
    [SerializeField] GameObject DiscardSlots;

    [SerializeField] GameObject[] cardOnSlots;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < boardSlots.Length; i++)
        {
            //cardOnSlots[i] = Random.Range(0, cards.Length);
        }

        for (int i = 0; i < cardOnSlots.Length; i++)
        {
            Instantiate(cardOnSlots[i], boardSlots[i].transform);
        }

        //Instantiate(cards[2], boardSlots[0].transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
