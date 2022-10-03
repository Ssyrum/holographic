using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleScript : MonoBehaviour
{

    List<GameObject> deckOfCards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject card1 = GameObject.Find("Card 1");
        GameObject card2 = GameObject.Find("Card 2");
        GameObject card3 = GameObject.Find("Card 3");
        GameObject card4 = GameObject.Find("Card 4");
        GameObject card5 = GameObject.Find("Card 5");

        
        deckOfCards.Add(card1);
        deckOfCards.Add(card2);
        deckOfCards.Add(card3);
        deckOfCards.Add(card4);
        deckOfCards.Add(card5);


    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            for (int i = deckOfCards.Count - 1; i > 0; i--)
            {
                int randomIndex = UnityEngine.Random.Range(0, i+1);
                GameObject temp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[randomIndex];
                deckOfCards[randomIndex] = temp;
                
            }

            deckOfCards[0].transform.position = new Vector3(0, 12, 0);
            deckOfCards[1].transform.position = new Vector3(0, 11, 0);
            deckOfCards[2].transform.position = new Vector3(0, 10, 0);
            deckOfCards[3].transform.position = new Vector3(0, 9, 0);
            deckOfCards[4].transform.position = new Vector3(0, 8, 0);

        }

        if (Input.GetMouseButtonDown(1))
        {
            deckOfCards[0].transform.position = new Vector3(-9, 12, -4);
        }

    }
}
