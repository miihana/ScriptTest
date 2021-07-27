using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
     }
}

public class Test : MonoBehaviour
{

    /*void HelloName(int name)
    {
        Debug.Log("Hello," + name);
    }

    //第一引数と第二引数の値を足した値を返す関数
    int Add(int a, int b)
    {
        // 第一引数と第二引数の値を足して、変数cに代入する
        int c = a + b;
        // 変数cを呼び出し元の関数に返す
        return c;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        /*コンソールにHello, World表示
        Debug.Log("Hello, World");

        //変数の宣言
        int score;
        //変数の代入
        score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);

        //変数の初期化
        int a = 3;
        int b = 4;
        //変数aと変数bの合計値を変数cに代入する
        int c = a + b;
        //変数cを表示
        Debug.Log(c);

        //moneyを２００で初期化
        int money = 50;
        if(money >= 100)
        {
            //moneyの値が１００以上の場合、文字列を表示する
            Debug.Log("ポーションを買う"); 
        }
        else
        {
            //moneyが１００未満の場合
            Debug.Log("武器を売る");
        }

        //moneyを１００で初期化
        int money = 100;
        if(money<=50)
        {
            Debug.Log("武器を売る");
        }
        else if(money>=200){
            Debug.Log("武器を買う");
        }
        else
        {
            Debug.Log("ポーションを買う");
        }

        //numを１で初期化する
        int num = 1;
        //valに代入する値を条件によって変える（三項演算子）
        int val = (num == 1) ? -100 : 100;
        //valの値を表示する
        Debug.Log(val);

        //変数aを３で初期化する
        int a = 3;
        if (a == 3)
        {
            int b = 5;
            Debug.Log("b="+b); //変数表示は対象の｛｝内で行う
        }

        //5回処理を繰り返す

        int sum = 0;

        for (int i= 1; i <=10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        //要素５の配列を初期化する
        int[] points = new int[5];

        //配列の各要素に値を代入
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        //配列の各要素を表示する
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        //配列の要素数分だけ処理を繰り返す
        for(int i=0; i < points.Length; i++)
        {
            //配列の要素が５０以上の場合
            if (points[i] >= 50){
                Debug.Log(points[i]);
        }
        }

        HelloName(6);

        int num = Add(3, 6);
        Debug.Log(num);

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);*/

        //提出課題
        int[] array = { 10, 20, 40, 60, 90 }; //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]); //各要素の値を順番に表示
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]); //各要素の値を逆順に表示
        }

        //発展課題
        Boss lastboss = new Boss();
        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
