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



                //席替えと日直
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




                //文化祭

            case 1101:
                StoryProgression.text = "夏休みが終わり、九月。\n高校生最後の文化祭がやってきた";
                break;
            case 1102:
                StoryProgression.text = "舞台発表や出店、どれも興味を唆る";
                break;
            case 1103:
                StoryProgression.text = "一人で回るのも寂しいから小春を誘おうと思う";
                break;
            case 1104:
                StoryProgression.text = "当番が終わってすぐの小春を誘うことにした";
                break;
            case 1105:
                StoryProgression.text = "「うん！いいよ！」";
                break;
            case 1106:
                StoryProgression.text = "朝から準備に追われて俺の一つ前の枠で\n当番をしていたのに元気だ";
                break;
            case 1107:
                StoryProgression.text = "「どこから回る？」";
                break;
            case 1108:
                StoryProgression.text = "そうだなぁ…";
                break;
            case 1109:
                StoryProgression.text = "――――――";
                break;
            case 1110:
                StoryProgression.text = "他クラスの出店を一通り回った後、他学年の舞台発表や展示を見て回った。";
                break;
            case 1111:
                StoryProgression.text = "全部を回った訳では無いけれど、時間が過ぎるのは早いもので。";
                break;
            case 1112:
                StoryProgression.text = "『文化祭を終了します』";
                break;
            case 1113:
                StoryProgression.text = "そんな終了宣言と共に高校最後の文化祭は終わりを迎えた";
                break;
            case 1114:
                StoryProgression.text = "――――――";
                break;
            case 1115:
                StoryProgression.text = "「終わっちゃったねー文化祭」";
                break;
            case 1116:
                StoryProgression.text = "二人での帰り道、小春がそんなことを言う";
                break;
            case 1117:
                StoryProgression.text = "「そういえば悠くんはまだ進路決めてないんだっけ？」";
                break;
            case 1118:
                StoryProgression.text = "不意にそんなことを聞かれる";
                break;
            case 1119:
                StoryProgression.text = "俺は未だに進学先を決めていなかった。先生からも色々\n言われているがどうしてもここが良いという進路\nが無かったのだ。";
                break;
            case 1120:
                StoryProgression.text = "少し前のを歩く小春の後ろ姿を見ながら、自分の進路を考える。";
                break;
            case 1121:
                StoryProgression.text = "「今日は誘ってくれてありがとうね！悠くん」";
                break;
            case 1122:
                StoryProgression.text = "パッと小春がこちらに振り返る。\nそれを俺は逃げる暇もなく目に入れてしまった。";
                break;
            case 1123:
                StoryProgression.text = "「あ、あぁうん。こちらこそ」";
                break;
            case 1124:
                StoryProgression.text = "ちょっと動揺しながら答えた。";
                break;
            case 1125:
                StoryProgression.text = "鼻歌を歌いながら機嫌よく歩く小春の後ろ姿がその日ずっと頭から離れなかった";
                break;
           

        }
    }
}
