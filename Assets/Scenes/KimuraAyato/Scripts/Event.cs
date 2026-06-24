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
    public int StandardizedScore = 40;//偏差値
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
            page++;//ページを1足す

        }
        switch (page)
        {
            //↓テンプレート(テキスト)
            //case 2:
            //    StoryProgression.text = "";
            //    break;

            //↓テンプレート(選択肢)
            //case 8:
            //    STORY.SetActive(true);
            //    Select.SetActive(true);
            //    img.sprite = title;
            //    StoryProgression.text = "";
            //    Options1.text = "1:" + "A";
            //    Options2.text = "2:" + "B";
            //    Options3.text = "3:" + "C";
            //    break;
            case 0:
                img.sprite = title;
                STORY.SetActive(false);
                break;
            case 1:
                StandardizedScore = 40;
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
        if (Input.GetKeyDown(KeyCode.UpArrow))//上矢印キーで上へ
        {
            if (SelNo > 0) SelNo--;//上にスタックしないようにセルナンバーを制限
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))//下矢印キーで下へ
        {
            if (SelNo < 2) SelNo++;//下にスタックしないようにセルナンバーを制限
        }
        Transform transform = SelAns.GetComponent<Transform>();
        switch (SelNo)
        {
            case 0:
                transform.localPosition = new Vector3(500, 400, 0);//セルアンスの位置調整
                break;
            case 1:
                transform.localPosition = new Vector3(500, 250, 0);//セルアンスの位置調整
                break;
            case 2:
                transform.localPosition = new Vector3(500, 100, 0);//セルアンスの位置調整
                break;

        }
    }
}
