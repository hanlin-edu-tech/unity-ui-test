using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Article : MonoBehaviour {

    string textData = @"Blue Jeans 

Blue jeans are an example of an <link=""american""><color=red>American</color></link> product that is <link=""popular""><color=red>popular</color></link> throughout the world. They were created by Levi Straus, a young German immigrant, in the 1850s in California. He made them for the gold miners there. The miners often ripped their pants at the knees and in the back because they had to kneel and bend looking for gold. Straus created a strong pair of overalls out of canvas, the material used to tents. He alter used a cotton from France called denim. The denim was brought from by ships with many Genoese sailors, from Genoa, Italy, in the crew. From this city’s name came the name jeans. 

Blue jeans were popular among <link=""cowboys""><color=red>cowboys</color></link> in the Wild West and came to the East only after the 1930s. Later, in the 1950s, movie stars such as James Dean and Marlon Brando made jeans popular with American teenagers. In the 1970s, designers such as Calvin Klein and Gloria Vanderbilt made blue jeans popular with people of all ages. Today people all over the world wear blue jeans, but the original idea came from the United States. 


中文摘意 

牛仔褲是美國產品受全世界矚目的例子之一,它是在1850年由一位德國的移民者在加州率先製作出來的.它是為加州的礦工設計的,因為礦工常需要跪著找金礦,所以褲子得膝蓋處和屁股的地方常會磨損,於是他用帳蓬的帆布來為工人製作工作褲.後來他改用來自法國稱之為丹寧的厚斜紋棉布製作.這種丹寧的厚斜紋棉布是由義大利的水手隨著船帶過來的,因此以這些義大利的人都市命中為Jeans. ";


    // Use this for initialization
    void Start () {
        GameObject.Find("Content").GetComponent<TextMeshProUGUI>().text = textData;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
