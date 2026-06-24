using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class Event.v100 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//もしエンターキーが押されたなら
        {
            if (page == 102)
            {
                if (SelNo != 1)//もしセルナンバーが1じゃなかったら
                {
                    page = 9999;
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
            
            //　休日デートイベ

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
                NovelParts.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                story.text = "どこへ行こうか";
                Select1.text = "1:" + "幼馴染を誘う";
                Select2.text = "2:" + "ゲームセンターに行く";
                Select2.text = "3:" + "本屋に行く";
                break;

            case 103:
                Select.SetActive(false);
                STORY.SetActive(true);
                StoryProgression.text = "小春を誘って適当に街をぶらつくことにした。";
                break;

            case 104:
                StoryProgression.text = "電話をすると二つ返事でOKだったので、家の前で待つ";
                break;

            case 105:
                StoryProgression.text = "「お待たせ！行こ！」";
                break;

            case 106:
                StoryProgression.text = "やけにテンションが高いようだが、気にしないで行く。";
                break;

            case 107:
                StoryProgression.text = "街に出て、いろんな店に入ったり雑貨屋に入ったりする。\n小春とこんなことをしたのは久しぶりかもしれない";
                break;

            case 108:
                StoryProgression.text = "学校で会うことも多かったからか、\n休みの日にわざわざ会うことは少なかった。\n隣の家だからというのもあるかも知れないな。";
                break;

            case 109:
                StoryProgression.text = "俺たちは少し電車で移動して水族館へ来た。\n小春が行きたいと言ったからだ。";
                break;

            case 110:
                StoryProgression.text = "「おっきいねー」";
                break;

            case 111;
                StoryProgression.text = "一番大きな水槽を泳ぐジンベイザメをみて小春が言う。";
                break;

            case 112:
                StoryProgression.text = "子供みたいに水槽に張り付き目を輝かせる小春に、\n俺は少しドキッとしてしまった。";
                break;

            case 113:
                StoryProgression.text = "(小春ってこんなに可愛かったか......？)";
                break;

            case 114:
                StoryProgression.text = "「楽しかったね！」";
                break;

            case 115:
                StoryProgression.text = "とびきりの笑顔を俺に向けてくる小春。\n思わず顔を逸らしてしまった。\n夕日に照らされている小春の顔は直視できるものではなかった";
                break;

            case 116:
                StoryProgression.text = "ずっと見てきた顔なのに。";
                break;

            case 117:
                StoryProgression.text = "「どうしたの？」";
                break;

            case 118:
                StoryProgression.text = "逸らした俺の顔を覗き込むように回り込んできた。";
                break;

            case 119:
                StoryProgression.text = "身長差と俺が俯いていたこともあり、\n上目遣いで俺を見てくる。";
                break;

            case 120:
                StoryProgression.text = "「おわっ！」";
                break;

            case 121:
                StoryProgression.text = "いきなり目の前に現れた小春の破壊力に\n思わず声をあげてしまった。";
                break;

            case 122:
                StoryProgression.text = "「ご、ごめん。驚かせちゃった？」\n「い、いや。大丈夫」";
                break;

            case 123:
                StoryProgression.text = "手のひらを向けて大丈夫だと示す。";
                break;

            case 124:
                StoryProgression.text = "家に帰ってからも\nその日の小春の顔が頭によぎって、\n夜もろくに眠れなかった。";
                break;

        }
    }
