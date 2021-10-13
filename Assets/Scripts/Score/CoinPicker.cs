// Written by bhavani

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour

{
    public TextMeshProUGUI text;
    // private float coin = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);

            SnapshotOriginator originator = new SnapshotOriginator(ScoreBoard.shared.GetPoints());
            ScoreKeeper caretaker = new ScoreKeeper(originator);

            List<CoinElement> coins = new List<CoinElement>();
                 
            IVisitor visitor = new PlayVisitor();
            CoinElement elt = new CoinElement();
            coins.Add(elt);

            foreach (CoinElement coin in coins)
            {
                coin.Accept(visitor);
            }
   
            Debug.Log("Now the score is" + ScoreBoard.shared.GetPoints());
            ScoreMemento memento = new ScoreMemento();
            
        }

    }

   
}
