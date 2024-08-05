

using System.ComponentModel.Design;
using ClassLibrary1;
using GeometryLibrary;

List<IFigure> figures = new List<IFigure>()
{
    new Circle(3),
    new Triangle(3, 4, 5),
    new Triangle(3, 6, 8)

};
Console.WriteLine("==========================");
foreach (var v in figures)
{
    Console.WriteLine("Площадь:" + v.CalculateArea());
    switch (v)
    {
        case Triangle triangle:
        {
            Console.Write("Это треугольник");
            Triangle t = triangle;
            if (t.IsRightTriangle())
                Console.Write("[еще и прямоугольный]");
            Console.WriteLine();
            break;
        }
        case Circle:
            Console.WriteLine("Ну, круг и круг, че бухтеть то");
            break;
    }
    Console.WriteLine("==========================");
}






//removeDuplicates();
//MaxProfit();
//Rotate();
//ContainsDuplicate();

//Arrays.PlusOne([9]);
//
// static void ContainsDuplicate()
// {
//     int[] nums = new[] { 1,1,1,3,3,4,3,2,4,2 };
//     bool ans = Arrays.ContainsDuplicate(nums);
//     Console.WriteLine(ans?"true":"false");
// }
// static void Rotate()
// {
//     int[] nums = new[] { -1, -100, 3, 99 };
//     Arrays.Rotate(nums, 2);
//     foreach (var v in nums)
//         Console.Write(v + " ");
// }
// static void removeDuplicates()
// {
//     int[] nums = [1, 1, 2]; // Input array
//     int[] expectedNums = [1, 2]; // The expected answer with correct length
//
//     int k = Arrays.RemoveDuplicates(nums); // Calls your implementation
//
//     Console.WriteLine(k);
//     for (int i = 0; i < k; i++) {
//         Console.Write(nums[i] + ",");
//     }
// }
//
// static void MaxProfit()
// {
//     int ans = Arrays.MaxProfit(new[] { 1,2,4,3,6});
//     Console.WriteLine(ans);
// }


