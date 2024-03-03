/*Task A.
Menerima input satu karakter dengan huruf kapital "Masukkan satu huruf: ". Jika input berupa
huruf vokal (A, I, U, E atau O) contoh outputnya adalah sebagai berikut (saat input dari user
adalah huruf "E"): Huruf E merupakan huruf vokal
Jika diberikan input "K", maka contoh outputnya adalah: Huruf E merupakan huruf vokal*/

Console.WriteLine("Masukan Satu Huruf: ");
string alfabet_1302223028 = Console.ReadLine();

if (alfabet_1302223028 == "A" || alfabet_1302223028 == "I" || alfabet_1302223028 == "U" ||
    alfabet_1302223028 == "E" || alfabet_1302223028 == "O")
{
    Console.WriteLine("Huruf " + alfabet_1302223028 + " Merupakan huruf vokal");
}
else
{
    Console.WriteLine("Huruf " + alfabet_1302223028 + " Merupakan huruf konsonan");
}


/*Task B.
Pada program tersebut, buatlah sebuah array bertipe integer dengan isi elemen berupa 5 
bilangan genap dari angka 2. Pada saat program dijalankan lakukan iterasi dan print output 
dari tiap elemen dengan contoh output sebagai berikut:
Angka genap 1:2
Angka genap 2:4
Angka genap 3:6
Angka genap 4:8
Angka genap 5: 10*/

int[] genap = { 2, 4, 6, 8, 10 };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Angka genap {i+1} : {genap[i]}");    
}

// *comment untuk ngerun salah satunya :)
