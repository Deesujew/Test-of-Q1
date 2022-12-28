Console.WriteLine("Введите массив строк в кавычках и через запятую:");
string output = Console.ReadLine();
char[] separators = new char[] { ' ', ',' };
String[] result = output.Split(separators);


int count = 0;

        for (int i = 0; i < result.Length; i++) 
        {
         if (result[i].Length<=5)
            {
                count++;  
            }
        }

string[] resume = new string[count];
int j = 0;
for ( int i=0; i < result.Length; i++)
    { 
        if (result[i].Length<=5)
            {
                resume[j]= result[i];
                j++;
            }
    }

WriteArray(resume);

void WriteArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

