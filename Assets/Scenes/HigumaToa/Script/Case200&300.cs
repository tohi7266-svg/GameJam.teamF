using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EventCase200 : MonoBehaviour
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
            if (page == 102)
            {
                if (SelNo == 1)
                {
                    page = 102;
                }
                else if (SelNo == 2)//もしセルナンバーが1じゃなかったら
                {
                    page = 199;
                    StandardizedScore = StandardizedScore - 5;
                }
                else
                {
                    page = 299;
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

            //　休日デートイベ分岐

            case 100:
                img.sprite = title;
                STORY.SetActive(false);
                break;

            case 101:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "夏休みの真ん中、\n1日暇な日ができたので出かけようかと思った。";
                break;

            case 102:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                story.text = "どこへ行こうか";
                Select1.text = "1:" + "幼馴染を誘う";
                Select2.text = "2:" + "ゲームセンターに行く";
                Select2.text = "3:" + "本屋に行く";
                break;

            //case100～終わり
            //case200～ゲーセン
            //知力 -5
            case 200:
                StoryProgression.text = "ゲームセンターに行くことにした。";
                break;

            case 201:
                StoryProgression.text = "適当にUFOキャッチャーで遊んだり、\nアーケードゲームで遊んだ。";
                break;

            case 202:
                StoryProgression.text = "楽しくその日を過ごすことができた。";
                break;

            //case300～本屋
            //知力 +20
            case 300:
                StoryProgression.text = "本屋に行くことにした";
                break;

            case 301:
                StoryProgression.text = "少し前まで追っていた漫画の最新刊を見つけ、\n購入することにした。";
                break;

            case 302:
                StoryProgression.text = "その他にもいくつか面白そうな漫画を購入した。";
                break;

            case 303:
                StoryProgression.text = "ついでに、参考書や勉強の役に立ちそうなものも購入した。\n進路こそ決めていないが、どの進路にしても\n困らないようにするためだ。";
                break;

        }
    }
}