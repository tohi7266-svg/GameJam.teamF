using UnityEngine;
using UnityEngine.UI;
public class Event : MonoBehaviour
{
    public Image Image;
    public GameObject STORY;//選択肢・テキストボックスの表示の操作のためのパーツ。選択肢などを中に入れる。
    public Text StoryProgression;//物語を表示するテキストボックス
    //画像
    public Sprite title;



    //選択肢
    public GameObject Select;//選択肢の表示の操作のためのパーツ。選択肢を中に入れる。
    public GameObject SelAns;//選択中背景
    public Text Options1;
    public Text Options2;
    public Text Options3;

    //変数
    public int StandardizedScore = 0;//偏差値
    public int Favorability = 0;//好感度

    private int page = 0;//ページ番号
    private int SelNo = 0;//選択中背景
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
            page++;//ページを1足す

        }
        switch (page)
        {
            //↓テンプレート(テキスト)
            //case 2:
            //    StoryProgression.text = "";
            //    break;

            case 0:
                img.sprite = title;
                STORY.SetActive(false);
                break;
            case 1:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "今日は高校最後の年の始業式。\n学年が変わるということはクラスも変わる。";
                break;

            case 2:
                StoryProgression.text = "俺は掲示されているクラス表を見ていた。";
                break;

            case 3:
                StoryProgression.text = "「悠くん。同じクラスだね！」";
                break;

            case 4:
                StoryProgression.text = "声をかけてきたのは\n幼馴染の逢沢 小春(あいざわ こはる)。\n小中高同じで隣に住んでいる女の子だ。";
                break;

            case 5:
                StoryProgression.text = "小さい頃から一緒だったが、\n高校で同じクラスになるのは初めてだ。";
                break;

            case 6:
                StoryProgression.text = "クラスでは各々が\n今までの友人などで集まっていた。";
                break;

            case 7:
                StoryProgression.text = "俺の友人たちは全員別クラスになっていて、知っている人は小春だけだった。";
                break;
        }
    }
}
