using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Temporary : MonoBehaviour
{
    public Text StoryProgression;

    private int page = 0;//ページ番号


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            //case 500:
            //StoryProgression.text = "";
            //break;
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
            case 500:
                StoryProgression.text = "この高校では5月上旬に\n体育祭が行われる。";
                break;

            case 501:
                StoryProgression.text = "俺は借人競走に出ることになっていた。";
                break;

            case 502:
                StoryProgression.text = "借人競走の時間になるまでは\n他の競技を見ながら過ごしていく。";
                break;

            case 503:
                StoryProgression.text = "体育祭も佳境を迎え、\n借人競走の時間がやってきた。";
                break;

            case 504:
                StoryProgression.text = "俺のクラスはこの借人競走で\n総合1位を取ることができれば";
                break;

            case 505:
                StoryProgression.text = "優勝は確実なものになる\nといった状況だった。";
                break;

            case 506:
                StoryProgression.text = "俺の番がやってきた。";
                break;

            case 507:
                StoryProgression.text = "俺は完璧なスタートを決め、\n一番にお題の札の元までたどり着いた。";
                break;

            case 508:
                StoryProgression.text = "すぐに取れる位置にあるのは3枚だ。\nどれにしようか。";
                break;

            case 509:
                StoryProgression.text = "俺は真ん中の札を取った。";
                break;

            case 510:
                StoryProgression.text = "内容は\n「この学校の生徒で1番信頼している人」\nだった。";
                break;

            case 511:
                StoryProgression.text = "俺は迷わずに小春の元へ向かい、\n手を引っ張る。";
                break;

            case 512:
                StoryProgression.text = "「えっ？えっ？」";
                break;

            case 513:
                StoryProgression.text = "いきなりのことに驚く小春や" +
                    "黄色い声をあげてくるクラスメイトたちの声を聞かないようにしながら、ゴールへ向かう。";
                break;

            case 514:
                StoryProgression.text = "迷わなかったことで余裕の1位を取ることができた。" +
                    "\n借人競走の総合1位はこれで確実なものとなった。";
                break;

            case 515:
                StoryProgression.text = "「ごめん。いきなり手を取って。」";
                break;

            case 516:
                StoryProgression.text = "「う、ううん！そ、それで\nお題はなんだったの？」";
                break;

            case 517:
                StoryProgression.text = "俺は手に持っていたお題を見せる。";
                break;

            case 518:
                StoryProgression.text = "「この学校の生徒で1番信頼している人・・・" +
                    "\nそっか・・・」";
                break;

            case 519:
                StoryProgression.text = "なぜだか落胆した様子だった。";
                break;

            case 520:
                StoryProgression.text = "俺はその落胆の理由が分からないまま、\n体育祭を終えた。";
                break;

        }
        }
}
