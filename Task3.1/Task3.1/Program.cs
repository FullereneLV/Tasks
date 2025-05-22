// See https://aka.ms/new-console-template for more information
using Task3._1;

int[] number = { 2, 3, 5, 25, 30 };
int[] num2 = { 10, 20, 30, 5 };
MyArray array = new MyArray(number);
array.Show();
array.Show("this is index in array");
MyArray array2 = new MyArray(num2);
array2.Show("index in array");
array2.Min();
array2.Max();
array2.Avg();
array2.Search(5);
array2.Search(11);
array2.SortDesc();
array2.SortAsc();
array.SortByParam(false);
array.SortByParam(true);