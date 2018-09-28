using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BusinessLogic
{
    public class BusinessCardManager : MonoBehaviour
    {
        // Start is called before the first frame update
        List<GameObject> BusinessCards;
        public GameObject BusinessCard;
        void Start()
        {
            Debug.Log("i was called");
            //BusinessCard = GameObject.FindGameObjectWithTag("BusinessCard");
            Debug.Log($"i am buisness card: {BusinessCard.name}");
            BusinessCards = new List<GameObject>();
            for (var i = 0; i < 10; i++)
            {
                var newCard = Instantiate(BusinessCard, 
                                          new Vector3(transform.position.x + 1 * (i * 6f), 0, 0), 
                                          Quaternion.identity);

                Debug.Log($"I made {i} card(s)");
                var textManager = newCard.GetComponentsInChildren<TextManager>();
                Debug.Log($"textManager is null? {textManager == null}");
                if (textManager != null)
                {
                    Debug.Log("hello???");
                    foreach (var text in textManager)
                    {
                        Debug.Log($"Bob number: {i}");
                        text.SetText($"Bob number: {i}");
                    }
                    BusinessCards.Add(newCard);
                }
            }
        }
    }
}

