using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ArticleLink : MonoBehaviour, IPointerClickHandler
{
    private TextMeshProUGUI pTextMeshPro;

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(pTextMeshPro, Input.mousePosition, null);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = pTextMeshPro.textInfo.linkInfo[linkIndex];
            print(linkInfo.GetLinkID());
        }
    }

    // Use this for initialization
    void Start () {
        pTextMeshPro = GetComponent<TextMeshProUGUI>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
