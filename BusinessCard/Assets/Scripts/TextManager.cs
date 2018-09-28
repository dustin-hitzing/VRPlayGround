using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BusinessLogic
{
    public class TextManager : MonoBehaviour
    {
        // Start is called before the first frame update
        TextMeshProUGUI textContainer;

        public void SetText(string text)
        {
            textContainer = GetComponent<TextMeshProUGUI>();
            textContainer.text = text;
        }
    }
}

