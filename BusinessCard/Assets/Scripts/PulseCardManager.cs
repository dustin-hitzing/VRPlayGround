using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PulseCardManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform Button;

    [SerializeField]
    int NumberOfCards = 1;

    [SerializeField]
    string TitleSet = "Default";

    void Start()
    {
        var cards = CreatePulseCards(TitleSet);
        foreach (var card in cards)
        { 
            var item = Instantiate(Button, transform);
            var textBlocks = item.GetComponentsInChildren<TextMeshProUGUI>();
            //todo: add implementation for adding buttons from a list and populating text
            textBlocks[0].text = card.Title;
            textBlocks[1].text = card.ScopeAndStrategy;
            textBlocks[2].text = card.Execution;
            textBlocks[3].text = card.Conclusion;
        }   
    }

    List<PulseCard> CreatePulseCards(string titleSet)
    {
        List<PulseCard> cards = new List<PulseCard>();
        for (var i = 0; i <= NumberOfCards; i++)
        {
            cards.Add(new PulseCard
            {
                Title = $"{titleSet} {i}",
                ScopeAndStrategy = $"{Random.Range(1, 100)}%",
                Execution = $"{Random.Range(1, 100)}%",
                Conclusion = $"{Random.Range(1, 100)}%"
            });
        }
        return cards;
    }
}

public class PulseCard
{
    public string Title;
    public string ScopeAndStrategy;
    public string Execution;
    public string Conclusion;
}