import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        int[] dizi = {4,3,6,7,6,8,9,2,4,6,7,3,4};
        int[] tekrarEdenSayılar=new int[dizi.length];
        int[] ciftSayılar = new int[tekrarEdenSayılar.length];

        int cift=2;



                for (int j = 0;j< dizi.length;j++){
                    for (int k = 0;k< dizi.length;k++){
                        if (j!=k &&(dizi[k]==dizi[j])){
                            if (!isFind(tekrarEdenSayılar,dizi[j])){
                                tekrarEdenSayılar[j]= dizi[j];

                            }
                            break;
                        }
                    }
                }

                for (int i = 0;i<tekrarEdenSayılar.length;i++){
                    if (tekrarEdenSayılar[i]%cift==0){
                        ciftSayılar[i]=tekrarEdenSayılar[i];
                    }
                }


        System.out.println(Arrays.toString(ciftSayılar));
    }
    static boolean isFind(int[] arr,int value){
        for (int i:arr) {
            if (i==value){
                return true;
            }
        }

        return false;
    }
}
/*
Şimdi sıra sende! Bir sayı dizisindeki tekrar eden
çift sayıları belirten bir program yazarak GitHub reposunu bizimle paylaşmalısın.
Kolay gelsin.
 */