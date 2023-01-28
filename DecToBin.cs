


int num = 20;
int[] buff =new int[100] ;
int cnt = 0 ;
string result = "";


Console.WriteLine("Input number Dec to Bin:");
num = Convert.ToInt16( Console.ReadLine());

for (int i = 0; num >= 0; i++)
{

    try 
    {

        buff[i] = num % 2;

        num = num / 2;

        Console.WriteLine("num remain   :" + num
                          + "\t Remainder   :" + num % 2);
        if (num <= 0)
        {
            break;
        }


        cnt += 1;

    }
    catch (Exception e) 
    {
        Console.WriteLine(e.Message);
        
    }

}

for (int i = cnt; i >=0; i--)
{
    result= result + buff[i]; 
    
}

Console.WriteLine(result);

Console.WriteLine("\n\n\n Press Enter To Exit");
Console.ReadLine();

