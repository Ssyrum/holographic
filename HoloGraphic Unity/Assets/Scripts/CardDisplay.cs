using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;
    //public Image artworkImage;
    public Text memoryText;
    public Text attackText;
    public Text defenseText;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        card.Print();
    }
}
