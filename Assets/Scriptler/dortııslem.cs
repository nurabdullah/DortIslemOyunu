using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dortııslem : MonoBehaviour
{
    public UnityEngine.UI.InputField sonucInput;
    public Text ilksayi,islem,ikincisayi, esittir,cevap, sonuc;
    int sayi1,sayi2,ıslemısareti;
    int islemsonucu;
    int maxsayi = 10;

    void Start()
    {
        YeniSoru();
    }


     public void cevapKontrol()
    {
        if (int.Parse(cevap.text) == islemsonucu)
        {
            sonuc.text = "DOGRU";



        }
        else { 
            sonuc.text = "YANLIS";
        }
    }

    public void YeniSoru()
    {
        sonuc.text = "";
        sonucInput.text = "";
        sayi1 = Random.Range(1, 20);
        sayi2 = Random.Range(1, 10);
        ıslemısareti = Random.Range(1, 5);

        switch (ıslemısareti)
        {
            case 1:
                islem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "/";
                islemsonucu = sayi1 / sayi2;
                break;
            case 4:
                islem.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";




    }
}
