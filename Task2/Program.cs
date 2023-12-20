int i1 = 5;
int i2 = 6;
int sum = i1 + i2; 
//Console.WriteLine(sum);

long l1 = 6;
long sum2 = l1 + i1; 
//Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 + i1;
//Console.WriteLine(sum3);

int product = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;
//Console.WriteLine(product);
//Console.WriteLine(product2);
//Console.WriteLine(product3);

int quotient = i1 / i2;
//Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1;
//Console.WriteLine(quotient2);

int a = 7;
int b = 6;
int c = 2;
float d = 8; //обязательно одному из целых чисел тип задать вещественный

double result = a * b / (c + d);
//должно получиться 6*7/(2+8)=4.2

Console.WriteLine(result);

//при int result = error CS0266: Не удается неявно преобразовать тип "float" в "int".
//при float result = 4,2
//при double result = 4,199999809265137