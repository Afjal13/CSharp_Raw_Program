//Nullable Types in C#
//declare three fields
int? firstNumber=null;
int secondNumber;
int? lastNumber = 150;
//Formula-1:
if (lastNumber == null)
    secondNumber = 0;
else
    secondNumber = (int)lastNumber; //or secondNumber = lastNumber.Value;
Console.WriteLine(secondNumber);
//Formula-2:
secondNumber = firstNumber ?? 0;//if firstnumber is null then 0 assign into secondnumber
Console.WriteLine(secondNumber);
secondNumber = lastNumber ?? 50; //if lastnumber null then 50 assign to secondnumber otherwise lastnumber assign into secondnumber 
Console.WriteLine(secondNumber);
//Formula-3:
secondNumber = (firstNumber == lastNumber) ? 50 : 100; //if condition true then 50 assign into otherwise 100 assign into secondnumber
Console.WriteLine(secondNumber);
//hold console window
Console.ReadKey();
//output:
//150
//0
//150
//100