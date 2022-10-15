<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form method="post" action="index.php">
        <input type="text" name="sayilar" placeholder="Sayıları Giriniz">
        <br>
        <span>Not: Lütfen boş bırakmayın.</span>
        <br>
        <input type="submit">
    </form>
    <?php
   $sayilar = $_POST["sayilar"];

      if(isset($number)){
         echo ("Lütfen boş bırakmayın.");
      }
      else {
         if ($sayilar % 3 == 0) {
            echo ($sayilar . " sayısı 3'e tam bölünüyor.");
         }
         else if($sayilar % 3 != 0) {
            $yenisayi = $sayilar;
   
            while (true) {
               if ($yenisayi % 3 == 0) {
                  echo ($yenisayi . " sayısı 3'e tam bölünüyor.");
                  echo ("<br>");
                  echo ("Eski sayı : ". $sayilar);
                  break;
               }
               else {
                  $yenisayi++;  
               }
            }
         }
      }
?>
</body>
</html>