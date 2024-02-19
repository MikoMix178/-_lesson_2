double X = 0.0;
double Y = -1.0;

if (X>0 && Y>0) {
    Console.WriteLine("Первая четверть");
} else if (X<0 && Y>0) {
    Console.WriteLine("Вторая четверть");
} else if (X<0 && Y<0) {
    Console.WriteLine("Третья четверть");
}   else if (X>0 && Y<0) {
    Console.WriteLine("Четвертая четверть");
} else {
    Console.WriteLine("Четверть не определить");
}