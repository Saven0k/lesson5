// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
Console.Clear();
int [] result_random = new int [12];
int[] Make_random_array(int minvalue , int maxvalue)
{
    Console.Write("[");
    for(int i = 0; i<12;i++)
    {
        result_random[i] = new Random().Next(minvalue , maxvalue+1);
        Console.Write(result_random[i] + ",");
    }
    Console.Write($"]");
    return result_random;
}
Make_random_array(-9,10);
int positive_result = 0;
int negative_result = 0;
foreach(int g in result_random)
{
    if (g>0) positive_result+=g;
    else if(g<0) negative_result+=g;
    else{}

}

Console.Write($" -> Сумма положительных чисел = {positive_result}; Сумма отрицательных чисел = {negative_result}");




