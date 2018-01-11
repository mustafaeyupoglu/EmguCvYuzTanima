

**Emgu Cv - Anlık Yüz Tanıma Uygulaması**

Uygulama anlık olarak kameradaki yüzleri tespit ediyor.

**İnput Formatı - Makine Öğrenmesi **
Uygulama başlatıldığında kameradaki görüntüyü alır. Bu görüntü framlerden oluşuyor bunu Image<Bgr, byte> tipine dönüştürür. böylece frameleri byte dizisi şekline getirilir.

Daha sonra dönüştürülen bu görüntü işlenebilmek için grayscale'e dönüştürülür. 

Bu tarz yüz tespiti, obje tespiti gibi uygulamalar için kullanılan xml tabanlı haar cascade dosyaları kullanılır. Bunlar bu tarz yapay zeka makine öğrenimleri için oluşturulmuş eğitim verileri bulunduran dosyalardır. Bunları internette bulmak mümkündür. 

Haar dosyasından Image byteları aranarak bulunan yüzler döndürülür. Ve başlangıçta yakaladığımız binary görüntü üzerine yazılır.


**Karmaşıklık Analizi**

Emgu Cv kütüphanesini incelersek detectMultiScale methodu makine öğrenmesinin yapıldığı methoddur.

Bu methoda gelen greyscale görüntü diziye koyularak haar dosyasında karşılaştırma yapılır.

Makine öğrenmesinin karmaşıklığını dll dosyalarının içinde ne olduğunu göremediğimiz için dizi boyutu kadar diye biliriz buda worst case de O(n) dir.

Test aşamasının karmaşıklığı ise foreach döngüsü tespit edilen her yüz için 1 kez dönecektir. Bu yüzden worst case de karmaşıklık O(n) dir.

My profile links
https://steemit.com/@primus1

https://utopian.io/@primus1

Contribution link
https://utopian.io/utopian-io/@primus1/c-face-recognition-app-with-emgu-cv-library
https://steemit.com/utopian-io/@primus1/c-face-recognition-app-with-emgu-cv-library
