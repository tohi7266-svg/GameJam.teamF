using UnityEngine;
using UnityEngine.UI;
public class eventkairyou : MonoBehaviour
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




            case 1000:
                StoryProgression.text = "「隣の席だね！悠くん！」";
                break;
            case 1001:
                StoryProgression.text = "くじ引きの翌日の朝、部活で先に学校に来ていた逢沢が\n教室に戻ってきて声をかけてきた";
                break;
            case 1002:
                StoryProgression.text = "「小中で何回か一緒になっただろ」";
                break;
            case 1003:
                StoryProgression.text = "高校じゃ初めてだからな。\nなんてことを思ったが口に出さなかった";
                break;
            case 1004:
                StoryProgression.text = "小春は嬉しそうにしている。\nそんなに嬉しいものだろうか。";
                break;
            case 1005:
                StoryProgression.text = "そんなことを考えていると、先生が入ってきてHRが始まった―";
                break;
            case 1006:
                StoryProgression.text = "「―それじゃあ桜庭と逢沢、今日の日直は二人に頼む」";
                break;
            case 1007:
                StoryProgression.text = "いきなり指名されてしまった";
                break;
            case 1008:
                StoryProgression.text = "「日直サボらないでよ？";
                break;
            case 1009:
                StoryProgression.text = "「俺をなんだと思っているんだ」";
                break;
            case 1010:
                StoryProgression.text = "小春からのからかうような言葉にムスッとした声で返す。";
                break;
            case 1011:
                StoryProgression.text = "―――放課後―――";
                break;
            case 1012:
                StoryProgression.text = "二人で黒板を消し、日誌を書く。";
                break;
            case 1013:
                StoryProgression.text = "「こうやって2人で何かするの久しぶりだね」";
                break;
            case 1014:
                StoryProgression.text = "不意にそんなことを言ってくる";
                break;
            case 1015:
                StoryProgression.text = "「そうだな…」";
                break;
            case 1016:
                StoryProgression.text = "時々話してくる小春の言葉に、\n一言二言返しながら日直の作業を進める。";
                break;
            case 1017:
                StoryProgression.text = "職員室へ持ってきて欲しいと頼まれていたプリント類を持ってきょうしつを出る。";
                break;
            case 1018:
                StoryProgression.text = "プリントを職員室に届けた後、一緒に帰路に着く。";
                break;
            case 1019:
                StoryProgression.text = "大したことでもないことを言い合いながら、二年通った道を2人で帰った";
                break;
            
        }
    }
}
