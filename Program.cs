using newStart;
/*
 * Задание №1
 */

// Console.Write("Введите кол-во чисел: ");
// int n = 0;
// List<int> num = new List<int>();
// n = int.Parse(Console.ReadLine());
//
// for(int i = 0; i < n; i++){
//     Console.Write($"Введите число №{i + 1}: ");
//     num.Add(int.Parse(Console.ReadLine()));
// }
//
// int resultSrednee = 0; int resultSlojenie = 0;
//
// foreach(int i in num){
//     resultSlojenie += i;
// }
//
// resultSrednee = resultSlojenie / n;
//
// Console.WriteLine("====[Результат]====");
// Console.WriteLine("Сложение: " + resultSlojenie);
// Console.WriteLine("Среднее: " + resultSrednee);

/*
 * Задание №2
 */

// List<string> str = new List<string>();
// Console.WriteLine("Введите текст, а затем напишите 'exit' в новой строке чтобы посчитать количество символов");
// int strLenght = 0;
//
// while(true){
//     string s = Console.ReadLine();
//     if (s == "exit") break;
//     str.Add(s);
// }
//
// foreach(string strLine in str){
//     strLenght += strLine.Length;
// }
//
// Console.WriteLine("Кол-во символов в тексте: " + strLenght);

/*
 * Задание №3
 */

// bool[,] monoMatrix = new bool[10,10];
// monoMatrix[1,1] = true;
//
// while(true){
//
//
//     // Отображение
//     for(int x = 0; x < 10; x++){
//         for(int y = 0; y < 10; y++){
//             Console.Write(monoMatrix[x,y] ? '1' : '0');
//         }
//         Console.WriteLine();
//     }
//     Console.Clear();
// }
/*
Counter counter = new Counter();
Counter counter2 = new Counter();
Counter counter3 = new Counter();
Counter counter4 = new Counter();
Counter counter5 = new Counter();
Counter counter6 = new Counter();
Counter counter8 = new Counter();
Counter counter9 = new Counter();
Counter counter0 = new Counter();
Counter counter354 = new Counter();*/

// List<int> teto = new List<int>();
// MyList<int> miku = new MyList<int>() {55, 745, 11};
//
// teto.Add(15);
// miku.Add(14);
// miku.Add(13);
// miku.Add(14);
// miku.Add(167);
// teto.Remove(15);
// miku.
//
// foreach (int i in miku){
//
// }


// BinaryHeap heap = new();
//
// Random r = new();
//
// for (int i = 0;i <= 10;i++){
//     heap.Add(r.Next(1, 100));
// }
//
// heap.Print();

Random random = new();

// [7, 14, null]
List<int> num = [7, 14, 4, 8, 11];


IEnumerable<int> numbers = num;

var sorted = Sorters.Order(numbers, (a, b) => a.CompareTo(b));

foreach (var n in sorted)
{
    Console.WriteLine(n);
}
