using static System.Console;
int[] Numbers = new int[2];
Numbers[0] = 0;
//WriteLine(Numbers[1]);
Numbers[1] = 1;
//display result
WriteLine("First output: ");
foreach (int i in Numbers)
    Write(Numbers[i] + " ");
//when need add more value in this array like that
//Numbers[2] =2; //then we get error
//in this sitution, our need resize array
//[Note:
//Array.Resize(ref Numbers, 1);//there are no error show but we lost our data because new size is less then previous size
//WriteLine(Numbers[1]); // get error
//]
Array.Resize(ref Numbers, 5);
Numbers[2] = 2;
Numbers[3] = 3;
Numbers[4] = 4;
//display result
WriteLine("\nSecond output: ");
foreach (int i in Numbers)
    Write(Numbers[i] + " ");
//hold console window
ReadKey();
//output:
//First output:
//0 1
//Second output:
//0 1 2 3 4

