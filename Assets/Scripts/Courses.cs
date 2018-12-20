using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Courses : MonoBehaviour {

    private class Displayabled
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    private class EduSystem : Displayabled
    {
        public List<Subject> Subjects { get; set; }
    }

    private class Subject : Displayabled
    {
        public Color Color { get; set; }
    }

    readonly List<EduSystem> menuDatas = new List<EduSystem> {
        new EduSystem { Code = "J", Name = "國中", Subjects = new List<Subject> {
            new Subject { Code = "JPC", Name = "國文", Color = new Color(0xFF, 0x00, 0x00) },
            new Subject { Code = "JMA", Name = "數學", Color = new Color(0x0F, 0xF0, 0x00) },
            new Subject { Code = "JEN", Name = "英語", Color = new Color(0x00, 0xFF, 0x00) },
            new Subject { Code = "JBI", Name = "生物", Color = new Color(0x00, 0x0F, 0xF0) },
            new Subject { Code = "JPY", Name = "理化", Color = new Color(0x00, 0x00, 0xFF) },
            new Subject { Code = "JEA", Name = "地科", Color = new Color(0xF0, 0x00, 0x0F) },
            new Subject { Code = "JGE", Name = "地理", Color = new Color(0xFF, 0xFF, 0x00) },
            new Subject { Code = "JHI", Name = "歷史", Color = new Color(0x00, 0xFF, 0xFF) },
            new Subject { Code = "JCT", Name = "公民", Color = new Color(0xFF, 0xFF, 0xFF) }
        }},
        new EduSystem { Code = "H", Name = "高中", Subjects = new List<Subject> {
            new Subject { Code = "JPC", Name = "國文", Color = new Color(0xFF, 0x00, 0x00) },
            new Subject { Code = "JMA", Name = "數學", Color = new Color(0x0F, 0xF0, 0x00) },
            new Subject { Code = "JEN", Name = "英語", Color = new Color(0x00, 0xFF, 0x00) },
            new Subject { Code = "JBI", Name = "自然", Color = new Color(0x00, 0x0F, 0xF0) },
            new Subject { Code = "JPY", Name = "社會", Color = new Color(0x00, 0x00, 0xFF) }
        }},
        new EduSystem { Code = "S", Name = "高職", Subjects = new List<Subject> {
            new Subject { Code = "JPC", Name = "國文", Color = new Color(0xFF, 0x00, 0x00) },
            new Subject { Code = "JMA", Name = "數學", Color = new Color(0x0F, 0xF0, 0x00) },
            new Subject { Code = "JEN", Name = "英語", Color = new Color(0x00, 0xFF, 0x00) },
            new Subject { Code = "JBI", Name = "自然", Color = new Color(0x00, 0x0F, 0xF0) },
            new Subject { Code = "JPY", Name = "社會", Color = new Color(0x00, 0x00, 0xFF) }
        }},
    };

    public GameObject educationalSystemTitleTemplate;

    public GameObject subjectPanelTemplate;

    public GameObject subjectButtonTemplate;


    void Start () {
        print("start");

        GameObject content = GameObject.Find("Content");

        menuDatas.ForEach((eduSystem) => {


            GameObject title = Instantiate(educationalSystemTitleTemplate);
            title.GetComponent<Text>().text = eduSystem.Name;
            title.GetComponent<RectTransform>().SetParent(content.transform);

            GameObject panel = Instantiate(subjectPanelTemplate);
            panel.GetComponent<RectTransform>().SetParent(content.transform);

            eduSystem.Subjects.ForEach((subject) =>
            {
                GameObject button = Instantiate(subjectButtonTemplate);
                button.GetComponent<SubjectButton>().code = subject.Code;
                button.GetComponent<Image>().color = subject.Color;
                button.GetComponentsInChildren<Text>()[0].text = subject.Name;
                button.GetComponent<RectTransform>().SetParent(panel.transform);
            });

        });

        LayoutRebuilder.MarkLayoutForRebuild(this.transform as RectTransform);
    }
	
	
	void Update () {

        LayoutRebuilder.MarkLayoutForRebuild(this.transform as RectTransform);

    }
}

