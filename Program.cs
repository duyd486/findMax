internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap do dai mang: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[size];
        for (int i = 0; i < size; i++) {
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = myArray[0];
        for (int i = 0; i < myArray.Length; i++) {
            if (myArray[i] > max) {
                max = myArray[i];
            }
        }
        Console.WriteLine("Gia tri lon nhat cua mang la: " + max);
    }

}