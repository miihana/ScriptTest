using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    //���@�U���p�̊֐�
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
     }
}

public class Test : MonoBehaviour
{

    /*void HelloName(int name)
    {
        Debug.Log("Hello," + name);
    }

    //�������Ƒ������̒l�𑫂����l��Ԃ��֐�
    int Add(int a, int b)
    {
        // �������Ƒ������̒l�𑫂��āA�ϐ�c�ɑ������
        int c = a + b;
        // �ϐ�c���Ăяo�����̊֐��ɕԂ�
        return c;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        /*�R���\�[����Hello, World�\��
        Debug.Log("Hello, World");

        //�ϐ��̐錾
        int score;
        //�ϐ��̑��
        score = 150;
        //�R���\�[���ɕϐ��̒��g��\��
        Debug.Log(score);

        //�ϐ��̏�����
        int a = 3;
        int b = 4;
        //�ϐ�a�ƕϐ�b�̍��v�l��ϐ�c�ɑ������
        int c = a + b;
        //�ϐ�c��\��
        Debug.Log(c);

        //money���Q�O�O�ŏ�����
        int money = 50;
        if(money >= 100)
        {
            //money�̒l���P�O�O�ȏ�̏ꍇ�A�������\������
            Debug.Log("�|�[�V�����𔃂�"); 
        }
        else
        {
            //money���P�O�O�����̏ꍇ
            Debug.Log("����𔄂�");
        }

        //money���P�O�O�ŏ�����
        int money = 100;
        if(money<=50)
        {
            Debug.Log("����𔄂�");
        }
        else if(money>=200){
            Debug.Log("����𔃂�");
        }
        else
        {
            Debug.Log("�|�[�V�����𔃂�");
        }

        //num���P�ŏ���������
        int num = 1;
        //val�ɑ������l�������ɂ���ĕς���i�O�����Z�q�j
        int val = (num == 1) ? -100 : 100;
        //val�̒l��\������
        Debug.Log(val);

        //�ϐ�a���R�ŏ���������
        int a = 3;
        if (a == 3)
        {
            int b = 5;
            Debug.Log("b="+b); //�ϐ��\���͑Ώۂ́o�p���ōs��
        }

        //5�񏈗����J��Ԃ�

        int sum = 0;

        for (int i= 1; i <=10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        //�v�f�T�̔z�������������
        int[] points = new int[5];

        //�z��̊e�v�f�ɒl����
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        //�z��̊e�v�f��\������
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        //�z��̗v�f���������������J��Ԃ�
        for(int i=0; i < points.Length; i++)
        {
            //�z��̗v�f���T�O�ȏ�̏ꍇ
            if (points[i] >= 50){
                Debug.Log(points[i]);
        }
        }

        HelloName(6);

        int num = Add(3, 6);
        Debug.Log(num);

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();
        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);*/

        //��o�ۑ�
        int[] array = { 10, 20, 40, 60, 90 }; //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ�����

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]); //�e�v�f�̒l�����Ԃɕ\��
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]); //�e�v�f�̒l���t���ɕ\��
        }

        //���W�ۑ�
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
