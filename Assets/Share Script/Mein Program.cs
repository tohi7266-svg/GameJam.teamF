using UnityEngine;
using UnityEngine.UI;

public class Novel : MonoBehaviour
{
    public Image Image;
    public GameObject NovelParts;
    public Sprite title;
    public Sprite page1;
    public Sprite page100;
    public GameObject SelAns;
    public Text story;
    public Text Select1;
    public Text Select2;
    public Text Select3;
    public GameObject Select;

    private int page = 0;
    private int SelNo = 0;
    private Image img;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = Image.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (page == 7)
            {
                if (SelNo != 1)
                {
                    page = 99;
                }
            }
            page++;
        }
        switch (page)
        {
            case 0:
                img.sprite = title;
                NovelParts.SetActive(false);
                break;

            case 1:
                NovelParts.SetActive(true);
                Select.SetActive(false);
                img.sprite = title;
                story.text = "特に用事のない8月7日．．．";
                break;

            case 2:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "暇なので、街に出てみたはいいものの、";
                break;

            case 3:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "今日は土曜日だったみたいだ。\n家族連れがちらほらと見える。";
                break;

            case 4:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "空は青く晴れ渡っていて、\nまさにお散歩日和って感じだ。";
                break;

            case 5:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "．．．";
                break;

            case 6:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "ただふらふらと歩いているのもなんだし、\nどこかに行こうかな？";
                break;

            case 7:
                NovelParts.SetActive(true);
                Select.SetActive(true);
                img.sprite = title;
                story.text = "何をしようか？";
                Select1.text = "1:" + "スーパーに行く";
                Select2.text = "2:" + "街を探索する";
                break;

            case 100:
                NovelParts.SetActive(true);
                Select.SetActive(false);
                img.sprite = title;
                story.text = "そういや、冷蔵庫の牛乳が切れそうなんだった。";
                break;

            case 101:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "少し歩くけど、あそこのスーパーに寄ろう。";
                break;

            case 102:
                NovelParts.SetActive(true);
                img.sprite = title;
                story.text = "えっと．．確かこの角を曲がって．．．";
                break;

            case 103:
                NovelParts.SetActive(true);
                img.sprite = page100;
                story.text = "．．．そうこうしているうちに\nスーパーに着いた。";
                break;

            case 104:
                NovelParts.SetActive(true);
                img.sprite = page100;
                break;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (SelNo > 0) SelNo--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (SelNo < 1) SelNo++;
        }
        Transform transform = SelAns.GetComponent<Transform>();
        switch (SelNo)
        {
            case 0:
                transform.localPosition = new Vector3(-300, 150, 0);
                break;
            case 1:
                transform.localPosition = new Vector3(300, 150, 0);
                break;

        }
    }
}
