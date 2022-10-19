<?php

class Sekil
{
   public $kenar,$kenar_uzunluk,$yükseklik;
   
   public function __construct($kenar = null,$kenar_uzunluk = null,$yükseklik = null)
   {
        $this->kenar = $kenar;
        $this->kenar_uzunluk = $kenar_uzunluk;
        $this->yükseklik = $yükseklik;
   }
}
class Kare extends Sekil
{
    public function alanı()
    {
        return pow($this->kenar,2);
    }
    public function cevresi()
    {
        return $this->kenar * 4;
    }
}
class Dikdortgen extends Sekil 
{
    public function alanı()
    {
        return $this->kenar_uzunluk * $this->kenar;
    }
    public function cevresi()
    {
        return ($this->kenar_uzunluk*2 + $this->kenar*2);
    }
}
class Ucgen extends Sekil
{
    public function alanı()
    {
        return ($this->kenar_uzunluk*$this->yükseklik)/2;
    }
}


$kare_1 = new Kare(5);
$dikdortgen_1 = new Dikdortgen(10,6);
$ücgen_1 = new Ucgen();


echo "Karenin Alanı " . $kare_1->alanı()."<br>";
echo "Karnin Çevresi " . $kare_1->cevresi(). "<br>" ;
echo "Dikdortgenin Alanı ". $dikdortgen_1->alanı()."<br>";
echo "Dikdortgenin Cevresi ". $dikdortgen_1->cevresi()."<br>";

/*
Ödev
-Sekil adında bir sınıf oluşturun ve bu sınıfından türeterek Dikdortgen, 
Ucgen ve Kare 
isimlerinde 3 sınıf daha oluşturun.
-Amacımız; en mantıklı yoldan daha az kod yazarak her
şeklin özelinde kendini alan ve çevrelerini hesaplamak.

    Değişkenler:
    -Kenar Uzunluğu
    


 */

?>

