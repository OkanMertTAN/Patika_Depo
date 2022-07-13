public class Employee {
    String tamAd;
    double maas;
    int calismaSaati;
    int baslangıcYılı=2022;
    int yil;

    Employee(String tamAd, double maas, int calismaSaati,int yil){
        this.tamAd=tamAd;
        this.maas=maas;
        this.calismaSaati=calismaSaati;
        this.yil=yil;
    }
    public void tax(double maas){
        
        double yenimaas,islem;
        if(maas>=1000){
            islem = (maas*0.03);
            yenimaas=maas-islem;
        }else{
            yenimaas =maas;
        }
        this.maas=yenimaas;
    }

    public void bonus(double maas){
        int sayac=0,islem;

        for (int i = this.calismaSaati;i>40;i--) {
            sayac++;
        }
        islem = sayac*30;
        maas+=islem;
        this.maas=maas;
    }
    public void raiseSalary(double maas,int yil){
        double islem;
        if(yil-this.baslangıcYılı<10){
            islem=maas*0.05;
            maas+=islem;
            this.maas=maas;
        }else if(yil-this.baslangıcYılı>=10&&yil-this.baslangıcYılı<20){
            islem=maas*0.10;
            maas+=islem;
            this.maas=maas;
        }else if(yil-this.baslangıcYılı>=20){ 
            islem=maas*0.15;
            maas+=islem;
            this.maas=maas;
        }else{
            this.maas=maas;
        }    
    }
    public void roString(){
        System.out.println("=================");
        System.out.println("Adınız"+tamAd);
        System.out.println("Maaşınız: "+maas);
        System.out.println("Çalışma Saatiniz : "+calismaSaati);
        System.out.println("Başlangıç Yılı : "+baslangıcYılı);
        
    }
}
/*
    Nitelikler: 
    name : Çalışanın adı ve soyadı
    salary : Çalışanın maaşı
    workHours : Haftalık çalışma saati
    hireYear : İşe başlangıç yılı

    Metotlar:
    Employee() Yapıcı Metot
    tax() : Maaşa uygulanan vergiyi hesaplayacaktır.
        Çalışanın maaşı 1000 TL'den az ise vergi uygulanmayacaktır.
        Çalışanın maaşı 1000 TL'den fazla ise maaşının %3'ü kadar vergi uygulanacaktır.
    bonus() : Eğer çalışan haftada 40 saatten fazla çalışmış ise 
        fazladan çalıştığı her saat başına 30 TL olacak şekilde bonus ücretleri hesaplayacaktır.
    raiseSalary() : Çalışanın işe başlangıç yılına göre maaş artışını hesaplayacaktır. 
        Şuan ki yılı 2021 olarak alın.
        Eğer çalışan 10 yıldan az bir süredir çalışıyorsa maaşına %5 zam yapılacaktır.
        Eğer çalışan 9 yıldan fazla ve 20 yıldan az çalışıyorsa maaşına %10 zam yapılacaktır.
        Eğer çalışan 19 yıldan fazla çalışıyorsa %15 zam yapılacaktır.
    toString() : Çalışana ait bilgileri ekrana bastıracaktır.    
 */