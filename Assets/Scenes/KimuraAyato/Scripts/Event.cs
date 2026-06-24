using UnityEngine;
using UnityEngine.UI;
public class Event : MonoBehaviour
{
    public Image Image;
    public GameObject STORY;//選択肢・テキストボックスの表示の操作のためのパーツ。選択肢などを中に入れる。
    public Text StoryProgression;//物語を表示するテキストボックス

    //画像
    public Sprite title;
    public Sprite SchoolSpring;
    public Sprite Class;

    //キャラ
    public GameObject Koharu;

    //選択肢
    public GameObject Select;//選択肢の表示の操作のためのパーツ。選択肢を中に入れる。
    public GameObject SelAns;//選択中背景
    public Text Options1;
    public Text Options2;
    public Text Options3;

    //変数
    public int StandardizedScore = 40;//偏差値
    public int Favorability = 0;//好感度

    public int page = 0;//ページ番号
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
            //席替え分岐
            if(page == 10)
            {
                if(SelNo == 0)
                {
                    page = 30;
                }
                else if(SelNo == 1)
                {
                    page = 10;
                }
                else
                {
                    page = 30;
                }
            }

            //体育祭分岐
            if (page == 42)
            {
                if (SelNo == 0)
                {
                    page = 54;
                }
                else if (SelNo == 1)
                {
                    page = 42;
                }
                else
                {
                    page = 54;
                }
            }

            //休日分岐
            if (page == 60)
            {
                if (SelNo == 0)
                {
                    page = 60;

                }
                else if (SelNo == 1)//もしセルナンバーが1だったら
                {
                    page = 82;
                    StandardizedScore = StandardizedScore - 5;
                }

                else
                {
                    page = 85;
                    StandardizedScore = StandardizedScore + 20;
                }
            }

            //文化祭分岐
            if (page == 93)
            {
                if (SelNo == 0)
                {
                    page = 93;
                }
                else if (SelNo == 1)
                {
                    page = 115;
                }
                else
                {
                    page = 118;
                }
            }

            //勉強分岐
            if (page == 126)
            {
                if (SelNo == 0)
                {
                    page = 126;
                }
                else if (SelNo == 1)//もしセルナンバーが1なら
                {
                    page = 131;
                    StandardizedScore = StandardizedScore - 5;
                }
                else
                {
                    page = 134;
                    StandardizedScore = StandardizedScore + 20;
                }
            }
            //エンディング分岐
            if (page == 137)
            {
                if (StandardizedScore < 40) //BAD END
                {
                    page = 146;
                }
             
                else                        //GOOD END
                {
                    page =  137;
                    if(page == 144)
                    {
                        return;
                    }
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

            //↓テンプレート(選択肢)
            //case 8:
            //STORY.SetActive(true);
            //Select.SetActive(true);
            //img.sprite = title;
            //StoryProgression.text = "";
            //Options1.text = "1:" + "A";
            //Options2.text = "2:" + "B";
            //Options3.text = "3:" + "C";
            //break;
        case 0:
                img.sprite = title;
                STORY.SetActive(false);
                Koharu.SetActive(false);
                break;
            case 1:
                StandardizedScore = 40;
                Select.SetActive(false);
                STORY.SetActive(true);
                img.sprite = SchoolSpring;
                StoryProgression.text = "今日は高校最後の年の始業式。\n学年が変わるということはクラスも変わる。";
                break;

            case 2:
                StoryProgression.text = "俺は掲示されているクラス表を見ていた。";
                break;

            case 3:
                StoryProgression.text = "「悠くん。同じクラスだね！」";
                break;

            case 4:
                Koharu.SetActive(true);
                StoryProgression.text = "声をかけてきたのは\n幼馴染の逢沢 小春(あいざわ こはる)。\n小中高同じで隣に住んでいる女の子だ。";
                break;

            case 5:
                StoryProgression.text = "小さい頃から一緒だったが、\n高校で同じクラスになるのは初めてだ。";
                break;

            case 6:
                img.sprite = Class;
                StoryProgression.text = "クラスでは各々が\n今までの友人などで集まっていた。";
                break;

            case 7:
                StoryProgression.text = "俺の友人たちは全員別クラスになっていて、知っている人は小春だけだった。";
                break;

            //席替えイベ
            case 8:
                StoryProgression.text = "新クラスになってから1ヶ月。\n席替えのくじ引きの日が来た。";
                break;

            case 9:
                StoryProgression.text = "クラスメイト達が引いていき、\n俺の番が来た。";
                break;

            case 10:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                StoryProgression.text = "くじの残りは3本";
                Options1.text = "1:" + "左を引く";
                Options2.text = "2:" + "真ん中を引く";    //幼馴染ルート
                Options3.text = "3:" + "右を引く";
                break;

            //席替え放課後
            case 11:
                StoryProgression.text = "「隣の席だね！悠くん！」";
                break;

            case 12:
                StoryProgression.text = "くじ引きの翌日の朝、部活で先に学校に来ていた逢沢が\n教室に戻ってきて声をかけてきた";
                break;

            case 13:
                StoryProgression.text = "「小中で何回か一緒になっただろ」";
                break;

            case 14:
                StoryProgression.text = "高校じゃ初めてだからな。\nなんてことを思ったが口に出さなかった";
                break;

            case 15:
                StoryProgression.text = "小春は嬉しそうにしている。\nそんなに嬉しいものだろうか。";
                break;

            case 16:
                StoryProgression.text = "そんなことを考えていると、先生が入ってきてHRが始まった―";
                break;

            case 17:
                StoryProgression.text = "「―それじゃあ桜庭と逢沢、今日の日直は二人に頼む」";
                break;

            case 18:
                StoryProgression.text = "いきなり指名されてしまった";
                break;

            case 19:
                StoryProgression.text = "「日直サボらないでよ？";
                break;

            case 20:
                StoryProgression.text = "「俺をなんだと思っているんだ」";
                break;

            case 21:
                StoryProgression.text = "小春からのからかうような言葉にムスッとした声で返す。";
                break;

            case 22:
                StoryProgression.text = "―――放課後―――";
                break;

            case 23:
                StoryProgression.text = "二人で黒板を消し、日誌を書く。";
                break;

            case 24:
                StoryProgression.text = "「こうやって2人で何かするの久しぶりだね」";
                break;

            case 25:
                StoryProgression.text = "不意にそんなことを言ってくる";
                break;

            case 26:
                StoryProgression.text = "「そうだな…」";
                break;

            case 27:
                StoryProgression.text = "時々話してくる小春の言葉に、\n一言二言返しながら日直の作業を進める。";
                break;

            case 28:
                StoryProgression.text = "職員室へ持ってきて欲しいと頼まれていたプリント類を持ってきょうしつを出る。";
                break;

            case 29:
                StoryProgression.text = "プリントを職員室に届けた後、一緒に帰路に着く。";
                break;

            case 30:
                StoryProgression.text = "大したことでもないことを言い合いながら、二年通った道を2人で帰った";
                break;

            case 31:
                StoryProgression.text = "隣になったのはクラスの男子だった。";
                break;

            case 32:
                StoryProgression.text = "それまで特に面識はなかったが、\n悪い奴ではなかったので普通に過ごせそうだ。";
                break;

            //体育祭
            case 33:
                StoryProgression.text = "この高校では5月上旬に\n体育祭が行われる。";
                break;

            case 34:
                StoryProgression.text = "俺は借人競走に出ることになっていた。";
                break;

            case 35:
                StoryProgression.text = "借人競走の時間になるまでは\n他の競技を見ながら過ごしていく。";
                break;

            case 36:
                StoryProgression.text = "体育祭も佳境を迎え、\n借人競走の時間がやってきた。";
                break;

            case 37:
                StoryProgression.text = "俺のクラスはこの借人競走で\n総合1位を取ることができれば";
                break;

            case 38:
                StoryProgression.text = "優勝は確実なものになる\nといった状況だった。";
                break;

            case 39:
                StoryProgression.text = "俺の番がやってきた。";
                break;

            case 40:
                StoryProgression.text = "俺は完璧なスタートを決め、\n一番にお題の札の元までたどり着いた。";
                break;

            case 41:
                StoryProgression.text = "すぐに取れる位置にあるのは3枚だ。";
                break;

            //体育祭くじ引き
            case 42:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                StoryProgression.text = "どれにしようか";
                Options1.text = "1:" + "左の札";
                Options2.text = "2:" + "真ん中の札";
                Options3.text = "3:" + "右の札";
                break;

            case 43:
                StoryProgression.text = "俺は真ん中の札を取った。";
                break;

            case 44:
                StoryProgression.text = "内容は\n「この学校の生徒で1番信頼している人」\nだった。";
                break;

            case 45:
                StoryProgression.text = "俺は迷わずに小春の元へ向かい、\n手を引っ張る。";
                break;

            case 46:
                StoryProgression.text = "「えっ？えっ？」";
                break;

            case 47:
                StoryProgression.text = "いきなりのことに驚く小春や" +
                    "黄色い声をあげてくるクラスメイトたちの声を聞かないようにしながら、ゴールへ向かう。";
                break;

            case 48:
                StoryProgression.text = "迷わなかったことで余裕の1位を取ることができた。" +
                    "\n借人競走の総合1位はこれで確実なものとなった。";
                break;

            case 49:
                StoryProgression.text = "「ごめん。いきなり手を取って。」";
                break;

            case 50:
                StoryProgression.text = "「う、ううん！そ、それで\nお題はなんだったの？」";
                break;

            case 51:
                StoryProgression.text = "俺は手に持っていたお題を見せる。";
                break;

            case 52:
                StoryProgression.text = "「この学校の生徒で1番信頼している人・・・" +
                    "\nそっか・・・」";
                break;

            case 53:
                StoryProgression.text = "なぜだか落胆した様子だった。";
                break;

            case 54:
                StoryProgression.text = "俺はその落胆の理由が分からないまま、\n体育祭を終えた。";
                break;

            //体育祭男子
            case 55:
                StoryProgression.text = "札をめくりお題を見る";
                break;

            case 56:
                StoryProgression.text = "すぐに学年の応援席に行き、\n他クラスの男子を連れて走る。";
                break;

            case 57:
                StoryProgression.text = "無事に1位でゴールすることができた。";
                break;

            case 58:
                img.sprite = title;
                STORY.SetActive(false);
                break;

            //休日
            case 59:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "夏休みの真ん中、\n1日暇な日ができたので出かけようかと思った。";
                break;

            case 60:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                StoryProgression.text = "どこへ行こうか";
                Options1.text = "1:" + "幼馴染を誘う";
                Options2.text = "2:" + "ゲームセンターに行く";
                Options3.text = "3:" + "本屋に行く";
                break;

            //休日デート
            case 61:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "小春を誘って適当に街をぶらつくことにした。";
                break;

            case 62:
                StoryProgression.text = "電話をすると二つ返事でOKだったので、家の前で待つ";
                break;

            case 63:
                StoryProgression.text = "「お待たせ！行こ！」";
                break;

            case 64:
                StoryProgression.text = "やけにテンションが高いようだが、気にしないで行く。";
                break;

            case 65:
                StoryProgression.text = "街に出て、いろんな店に入ったり雑貨屋に入ったりする。\n小春とこんなことをしたのは久しぶりかもしれない";
                break;

            case 66:
                StoryProgression.text = "学校で会うことも多かったからか、\n休みの日にわざわざ会うことは少なかった。\n隣の家だからというのもあるかも知れないな。";
                break;

            case 67:
                StoryProgression.text = "俺たちは少し電車で移動して水族館へ来た。\n小春が行きたいと言ったからだ。";
                break;

            case 68:
                StoryProgression.text = "「おっきいねー」";
                break;

            case 69:
                StoryProgression.text = "一番大きな水槽を泳ぐジンベイザメをみて小春が言う。";
                break;

            case 70:
                StoryProgression.text = "子供みたいに水槽に張り付き目を輝かせる小春に、\n俺は少しドキッとしてしまった。";
                break;

            case 71:
                StoryProgression.text = "(小春ってこんなに可愛かったか......？)";
                break;

            case 72:
                StoryProgression.text = "「楽しかったね！」";
                break;

            case 73:
                StoryProgression.text = "とびきりの笑顔を俺に向けてくる小春。\n思わず顔を逸らしてしまった。\n夕日に照らされている小春の顔は直視できるものではなかった";
                break;

            case 74:
                StoryProgression.text = "ずっと見てきた顔なのに。";
                break;

            case 75:
                StoryProgression.text = "「どうしたの？」";
                break;

            case 76:
                StoryProgression.text = "逸らした俺の顔を覗き込むように回り込んできた。";
                break;

            case 77:
                StoryProgression.text = "身長差と俺が俯いていたこともあり、\n上目遣いで俺を見てくる。";
                break;

            case 78:
                StoryProgression.text = "「おわっ！」";
                break;

            case 79:
                StoryProgression.text = "いきなり目の前に現れた小春の破壊力に\n思わず声をあげてしまった。";
                break;

            case 80:
                StoryProgression.text = "「ご、ごめん。驚かせちゃった？」\n「い、いや。大丈夫」";
                break;

            case 81:
                StoryProgression.text = "手のひらを向けて大丈夫だと示す。";
                break;

            case 82:
                StoryProgression.text = "家に帰ってからも\nその日の小春の顔が頭によぎって、\n夜もろくに眠れなかった。";

                break;
            
            //休日ゲーセン
            //知力 -5
            case 83:
                StoryProgression.text = "ゲームセンターに行くことにした。";
                break;

            case 84:
                StoryProgression.text = "適当にUFOキャッチャーで遊んだり、\nアーケードゲームで遊んだ。";
                break;

            case 85:
                StoryProgression.text = "楽しくその日を過ごすことができた。";
                break;

            //休日本屋
            //知力 +20
            case 86:
                StoryProgression.text = "本屋に行くことにした";
                break;

            case 87:
                StoryProgression.text = "少し前まで追っていた漫画の最新刊を見つけ、\n購入することにした。";
                break;

            case 88:
                StoryProgression.text = "その他にもいくつか面白そうな漫画を購入した。";
                break;

            case 89:
                StoryProgression.text = "ついでに、参考書や勉強の役に立ちそうなものも購入した。\n進路こそ決めていないが、どの進路にしても\n困らないようにするためだ。";
                break;

                //文化祭
            case 90:
                StoryProgression.text = "夏休みが終わり、九月。\n高校生最後の文化祭がやってきた";
                break;
            case 91:
                StoryProgression.text = "舞台発表や出店、どれも興味を唆る";
                break;
            case 92:
                StoryProgression.text = "一人で回るのも寂しいから誰かを誘おうと思う";
                break;

            //文化祭選択
            case 93:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                StoryProgression.text = "誰を誘おうか";
                Options1.text = "1:" + "小春";
                Options2.text = "2:" + "一人で回る";
                Options3.text = "3:" + "クラスメイトを誘う";
                break;

            case 94:
                StoryProgression.text = "当番が終わってすぐの小春を誘うことにした";
                break;

            case 95:
                StoryProgression.text = "「うん！いいよ！」";
                break;

            case 96:
                StoryProgression.text = "朝から準備に追われて俺の一つ前の枠で\n当番をしていたのに元気だ";
                break;

            case 97:
                StoryProgression.text = "「どこから回る？」";
                break;

            case 98:
                StoryProgression.text = "そうだなぁ…";
                break;

            case 99:
                StoryProgression.text = "――――――";
                break;

            case 100:
                StoryProgression.text = "他クラスの出店を一通り回った後、他学年の舞台発表や展示を見て回った。";
                break;

            case 101:
                StoryProgression.text = "全部を回った訳では無いけれど、時間が過ぎるのは早いもので。";
                break;

            case 102:
                StoryProgression.text = "『文化祭を終了します』";
                break;

            case 103:
                StoryProgression.text = "そんな終了宣言と共に高校最後の文化祭は終わりを迎えた";
                break;

            case 104:
                StoryProgression.text = "――――――";
                break;

            case 105:
                StoryProgression.text = "「終わっちゃったねー文化祭」";
                break;

            case 106:
                StoryProgression.text = "二人での帰り道、小春がそんなことを言う";
                break;

            case 107:
                StoryProgression.text = "「そういえば悠くんはまだ進路決めてないんだっけ？」";
                break;

            case 108:
                StoryProgression.text = "不意にそんなことを聞かれる";
                break;

            case 109:
                StoryProgression.text = "俺は未だに進学先を決めていなかった。先生からも色々\n言われているがどうしてもここが良いという進路\nが無かったのだ。";
                break;

            case 110:
                StoryProgression.text = "少し前のを歩く小春の後ろ姿を見ながら、自分の進路を考える。";
                break;

            case 111:
                StoryProgression.text = "「今日は誘ってくれてありがとうね！悠くん」";
                break;

            case 112:
                StoryProgression.text = "パッと小春がこちらに振り返る。\nそれを俺は逃げる暇もなく目に入れてしまった。";
                break;

            case 113:
                StoryProgression.text = "「あ、あぁうん。こちらこそ」";
                break;

            case 114:
                StoryProgression.text = "ちょっと動揺しながら答えた。";
                break;

            case 115:
                StoryProgression.text = "鼻歌を歌いながら機嫌よく歩く小春の後ろ姿がその日ずっと頭から離れなかった";
                break;

            //文化祭単独
            case 116:
                StoryProgression.text = "誰かを誘おうと思ったが、\n誘える人がいなかったので一人で回ることにした。";
                break;

            case 117:
                StoryProgression.text = "『文化祭を終了します』";
                break;

            case 118:
                StoryProgression.text = "そんな終了宣言と共に高校最後の文化祭は終わりを迎えた";
                break;

            //文化祭クラスメイト
            case 119:
                StoryProgression.text = "近くにいたクラスメイトを誘い、\n文化祭を回ることにした。";
                break;

            case 120:
                StoryProgression.text = "『文化祭を終了します』";
                break;

            case 121:
                StoryProgression.text = "そんな終了宣言と共に高校最後の文化祭は終わりを迎えた";
                break;

            case 122:
                img.sprite = title;
                STORY.SetActive(false);
                break;

            case 123:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "2学期も終わりが近づいてきた。\n高校3年は実質この2学期で終わり。";
                break;

            case 124:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "だがその前に重要なものが残っている。\n期末テストだ。";
                break;

            case 125:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "テスト勉強を一人でやっても\n効率が悪いので誰かを誘おう。";
                break;

            case 126:
                STORY.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
               StoryProgression.text = "誰を誘おうか";
                Options1.text = "1:" + "小春";
                Options2.text = "2:" + "やらない";
                Options3.text = "3:" + "1人でやる";
                break;
            //勉強小春
            case 127:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "小春を誘うことにした。";
                break;

            case 128:
                StoryProgression.text = "放課後に俺の家でテスト勉強をすることになった。\nお互いに教え合いながらテスト勉強を進めていった";
                break;

            case 129:
                StoryProgression.text = "これなら期末テストも問題ないだろう。";
                break;

            case 130:
                StoryProgression.text = "「もう2学期も終わっちゃうけど...\n進路は決めたの？」";
                break;

            case 131:
                StoryProgression.text = "俺は──────";
                break;

            //勉強やらない
            case 132:
                StoryProgression.text = "誘える人も思いつかないし、1人でやるのも面倒なので\nやらないことにした。";
                break;

            case 133:
                StoryProgression.text = "やらなくても期末テストはそれなりに取れる自信がある。";
                break;

            //勉強単独
            case 134:
                StoryProgression.text = "誘える人も思いつかなかったので\n図書館に行って1人で勉強することにした。";
                break;

            case 135:
                StoryProgression.text = "時期が時期なので他校の学生の姿も見受けられた。";
                break;

            case 136:
                StoryProgression.text = "1人では効率が悪いと思ったが、\n意外にも集中して勉強を進めることができた。";
                break;

            case 137:
                StoryProgression.text = "1月、俺は共通テストを終えた。";
                break;

            //GOOD END
            case 138:
                StoryProgression.text = "「やった！私たちどっちも合格だよ！」";
                break;

            case 139:
                StoryProgression.text = "小春がこちらを見て言う。";
                break;

            case 140:
                StoryProgression.text = "俺は小春と同じ大学にすすんだ。";
                break;

            case 141:
                StoryProgression.text = "決めたのはギリギリではあったが、\n難なく合格することができた";
                break;

            case 142:
                StoryProgression.text = "ここに決めた理由はまだ小春には伝えてない。";
                break;

            case 143:
                StoryProgression.text = "ここに決めたのは…";
                break;

            case 144:
                StoryProgression.text = "小春がいたから―――";
                break;

            case 145:
                StoryProgression.text = "ＧＯＯＤ　ＥＮＤ";
                break;

                case 146:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    page = 0;
                }
                break;


            //BAD END
            case 147:
                StoryProgression.text = "俺は燃え尽きていた";
                break;

            case 148:
                StoryProgression.text = "決めた進路先の受験に失敗したのだ";
                break;

            case 149:
                StoryProgression.text = "実力が及ばなかった";
                break;

            case 150:
                StoryProgression.text = "滑り止めに行く気も起きず、浪人することにした。";
                break;

            case 151:
                StoryProgression.text = "BAD END";
                break;

            case 152:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    page = 0;
                }
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
        //席替え小春
        if(page == 30)
        {
            page = 33;
        }
        //体育祭小春
        if(page == 54)
        {
            page = 58;
        }
        //休日小春
        if (page == 82)
        {
            page = 90;
        }
        //休日ゲーセン
        if (page == 83)
        {
            page = 90;
        }
        //文化祭小春
        if (page == 115)
        {
            page = 122;
        }
        //文化祭ソロ
        if (page == 118)
        {
            page = 122;
        }
        //勉強イベ小春
        if(page == 126)
        {
            page = 137;
        }
        if(page == 132)
        {
            page = 137;
        }

    }
}
