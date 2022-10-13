<?php
    //Üçgün Çizimi

    function ucgen($parametre){//Parametre ile üçgenin satır sırasını istenir.
        for ($i=0; $i <= $parametre ; $i++) { //$i değişkeni satırdaki "*" işaretini sayısını belli eder.
            $a = 0;
            while ($a <= $i) {//$i değişkeni değeri kadar dönmesini sağlıyoruz,
                $a++;//Döngünün sonlanması için her döngüde 1 arttrılır.
                echo "*";//Her dönüşte "*" yazdırılır,
            }
            echo "<br>";//Bir sonraki satıra geçer,
        }
    }
    ucgen(25);

?>