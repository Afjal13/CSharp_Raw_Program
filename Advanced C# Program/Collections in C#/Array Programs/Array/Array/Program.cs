//simple array defination method 1
int[] numbers = new int[2];
numbers[0] = 1; 
numbers[1] = 2;
Console.WriteLine($"\nMethod 1 is: {numbers[0]}");
//method 2
int[] numbers1;
numbers1 = new int[2];
numbers1[0]=1;
numbers1[1]=2;
Console.WriteLine($"\nMethod 2 is: {numbers1[1]}");
//method 3
int[] numbers2 = { 1, 2, 3 };
Console.WriteLine($"\nMethod 3 is: {numbers2[0]}");
//2D array method 4
int[,] numbers3 = new int[2,3];
numbers3[0,0] = 1;
numbers3[0,1] = 2;
numbers3[0,2] = 3;
numbers3[1,0] = 4;
numbers3[1,1] = 5;
numbers3[1,2] = 6;
Console.WriteLine($"\nMethod 4 is: {numbers3[0,2]}");
//multi-dimentional array method 5 
//type[,,.....] arrayName = new type [2,3,2,.....];
int [,,] numbers4 = new int[2,3,2];
numbers4[0,0,0] = 1;
numbers4[0,0,1] = 2;
numbers4[0,1,0] = 3;
numbers4[0,1,1] = 4;
numbers4[0,2,0] = 5;
numbers4[0,2,1] = 6;
numbers4[1,0,0] = 7;
numbers4[1,0,1] = 8;
numbers4[1,1,0] = 9;
numbers4[1,1,1] = 10;
numbers4[1,2,0] = 11;
numbers4[1,2,1] = 12;
Console.WriteLine($"\nMethod 5 is: {numbers4[1,1,1]}");
//jagged array method 6
string[][] JaggedArray=new string[3][]
{
    new string[]{"BBA","MBA"},
    new string[]{"BSc","MSc","MBA"},
    new string[]{"SSc"}
};

Console.WriteLine($"\nMethod 6 is: {JaggedArray[0][1]}");

Console.ReadKey();

