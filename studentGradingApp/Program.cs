// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zipi1 = 84;
int zipi2 = 96;
int zipi3 = 73;
int zipi4 = 85;
int zipi5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

//Calcualting sums
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zipiSum = zipi1 + zipi2 + zipi3 + zipi4 + zipi5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zipiScore = (decimal) zipiSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zipi:\t\t" + zipiScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");