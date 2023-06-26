using lab1; //унифицированный язык моделирования тип элемента модели

C1 c1 = new C1();
C1 c2 = new C1(1,"qwe",'a',2,3,4);
C1 c3 = new C1(c1);



c1.Second();
Console.WriteLine(c2.three);
Console.WriteLine(c2.Six);




C2 c4 = new C2();
C2 c5 = new C2(1, "qwe", 'a', 2, 3, 4);
C2 c6 = new C2(c4);

c5[3] = 5;

Console.WriteLine();
Console.WriteLine(c5[3]);
Console.WriteLine();

c1.Second();
Console.WriteLine(c5.three);
Console.WriteLine(c5.Six);



C4 c41 = new C4(1,2);

c41.c3Method();
c41.c4Method();

Console.WriteLine(c41.c);
Console.WriteLine(c41.d);
Console.WriteLine(c41.g);

//способность к изменению функций, унаследованных от базового класса
//это свойство системы, позволяющее объединить данные и методы и скрыть детали реализации от пользователя