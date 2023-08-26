/*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
 A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, 
 a nota B tem peso 3 e a nota C tem peso 5. 
 Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.*/


double a, b, c, mediaa, mediab, mediac,total;

a = double.Parse(Console.ReadLine());   
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
mediaa = a * 0.2;
mediab = b * 0.3;
mediac = c * 0.5;
total = mediac+mediab+mediaa;

Console.WriteLine("MEDIA = "+total);
