using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EventCase1500 : MonoBehaviour
{
    public Image Image;
    public GameObject STORY;//選択肢・テキストボックスの表示の操作のためのパーツ。選択肢などを中に入れる。
    public Text StoryProgression;//物語を表示するテキストボックス
    public Text story;
    //画像
    public Sprite title;



    //選択肢
    public GameObject Select;//選択肢の表示の操作のためのパーツ。選択肢を中に入れる。
    public GameObject SelAns;//選択中背景
    public Text Select1;
    public Text Select2;
    public Text Select3;

    //変数
    public int StandardizedScore = 0;//偏差値
    public int Favorability = 0;//好感度

    private int page = 0;//ページ番号
    private int SelNo = 0;//選択中背景
                          //その他
    private Image img;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = Image.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//もしエンターキーが押されたなら
        {
            if (page == 1504)
            {
                if (SelNo == 1)//もしセルナンバーが1じゃなかったら
                {
                    page = 1504;
                }
                else if (SelNo == 2)
                {
                    page = 1599;
                    StandardizedScore = StandardizedScore - 5;
                }
                else
                {
                    page = 1699;
                    StandardizedScore = StandardizedScore + 20;
                }
            }
            page++;//ページを1足す

        }
        switch (page)
        {
            //↓テンプレート(テキスト)
            //case 2:
            //    StoryProgression.text = "";
            //    break;

            //　勉強イベ

            case 1500:
                img.sprite = title;
                STORY.SetActive(false);
                break;

            case 1501:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "2学期も終わりが近づいてきた。\n高校3年は実質この2学期で終わり。";
                break;

            case 1502:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "だがその前に重要なものが残っている。\n期末テストだ。";
                break;

            case 1503:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "テスト勉強を一人でやっても\n効率が悪いので誰かを誘おう。";
                break;

            case 1504:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                story.text = "誰を誘おうか";
                Select1.text = "1:" + "幼馴染";
                Select2.text = "2:" + "やらない";
                Select2.text = "3:" + "1人でやる";
                break;
            //勉強イベメイン
            case 1505:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "小春を誘うことにした。";
                break;

            case 1506:
                StoryProgression.text = "放課後に俺の家でテスト勉強をすることになった。\nお互いに教え合いながらテスト勉強を進めていった";
                break;

            case 1507:
                StoryProgression.text = "これなら期末テストも問題ないだろう。";
                break;

            case 1508:
                StoryProgression.text = "「もう2学期も終わっちゃうけど...\n進路は決めたの？」";
                break;

            case 1509:
                StoryProgression.text = "俺は──────";
                break;

            //勉強イベ分岐1600～
            case 1600:
                StoryProgression.text = "誘える人も思いつかないし、1人でやるのも面倒なので\nやらないことにした。";
                break;

            case 1601:
                StoryProgression.text = "やらなくても期末テストはそれなりに取れる自信がある。";
                break;

            //勉強イベ分岐1700～
            case 1700:
                StoryProgression.text = "誘える人も思いつかなかったので\n図書館に行って1人で勉強することにした。";
                break;

            case 1701:
                StoryProgression.text = "時期が時期なので他校の学生の姿も見受けられた。";
                break;

            case 1702:
                StoryProgression.text = "1人では効率が悪いと思ったが、\n意外にも集中して勉強を進めることができた。";
                break;

        }
    }
}