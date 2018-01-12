

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

 **Emgu Cv - Face recognition app**
 
 This app is recognizing faces in your webcam.

 **İnput Format - Machine Learning**
 When the application is started, it captures the image on the camera. And this image made by frames.

Image<Bgr, byte> binaryGoruntu = webcam.QueryFrame().ToImage<Bgr, Byte>()
in this row we are converting frames to Image<Bgr, byte> Array.

After that for the process this converted image , we need to convert image to grayscale.

 Image<Gray, byte> greyScaleGoruntu = binaryGoruntu.Convert<Gray, byte>();
This type of facial recognition, object detection apps generally use XML based HAAR CASCADEfiles.
These files are containing training data for machine learning. You can find these files in the Internet.

The images are searching in the Haar file and the found faces are return. And the binary image we captured at the beginning is overwritten.

Rectangle[] rectangles = haar.DetectMultiScale(greyScaleGoruntu, 1.4, 1, new Size(100, 100), new Size(800, 800));
                    foreach (var face in rectangles)
                    {
                        binaryGoruntu.Draw(face, new Bgr(0, double.MaxValue, 0), 3);
                    }
                    pictureBox1.Image = binaryGoruntu.ToBitmap();
                    
**Complexity Analysis**
When you examine the Emgu Cv library, detectMultiScale method is the method of machine learning.

In the worst case Complexity is O(n).

The complexity of the test phase is O(n) because foreach loop will return once.


My profile links

https://steemit.com/@primus1

https://utopian.io/@primus1

Contribution link
https://utopian.io/utopian-io/@primus1/c-face-recognition-app-with-emgu-cv-library
https://steemit.com/utopian-io/@primus1/c-face-recognition-app-with-emgu-cv-library
