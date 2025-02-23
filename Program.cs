int[] arr = [2, 8, 5, 4, 11,];

List<int> list = [];

for (int i = 0; i < arr.Length; i++)
{

    var result = 0;


    for (int j = 0; j < arr.Length; j++)
    {

        if (i != j)
        {
            result += arr[j];

        }


    }

    list.Add(result);


}

var max = list.Max();
var min = list.Min();
Console.WriteLine(min.ToString() + " " + max.ToString());
