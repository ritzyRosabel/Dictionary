using System;
using System.Collections.Generic;

class Program
{
    //If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".

    static void Main(string[] args)
    {
        string myInput = "[name]:opemipo|[age]:16|[insert link]:https://google.com";
        string myTextFile = "I am going home with [name] and her age is [age]. I am with  [name] and her age is [age]. My name is  [name] and my age is [age] also you can meet her at [insert link] ";



        //var myKeyValuePair = Format(myInput);
        //foreach (var item in myKeyValuePair)
        //{
        //    myTextFile = myTextFile.Replace(item.Key, item.Value);
        //}  
        
        var myKeyValuePair = Formats(myInput);
        foreach (var item in myKeyValuePair)
        {
            myTextFile = myTextFile.Replace(item.Key, item.Value);
        }



        Console.WriteLine(myTextFile);
        Console.WriteLine(myTextFile);
        Console.ReadLine();




    }



    static Dictionary<string, string> Format(string args)
    {
        var myParameters = new Dictionary<string, string>();



        if (args.Length > 0)
        {
            var stringArr = args.Split('|');
            for (int i = 0; i < stringArr.Length; i++)
            {
                var parArray = stringArr[i].Split(':');
                var parKey = parArray[0];
                var parValue = parArray[1];
                myParameters.Add(parKey, parValue);
            }
        }
        return myParameters;

    }


    static Dictionary<string, string> Formats(string args)
    {
        var myParameters = new Dictionary<string, string>();



        if (args.Length > 0)
        {
            var stringArr = args.Split('|');
            for (int i = 0; i < stringArr.Length; i++)
            {
                var parArray = stringArr[i].Split(':');
                var parKey = parArray[0].Trim();
                var parValue = string.Empty;
                for (int j = 1; j < parArray.Length; j++)
                {



                    if (string.IsNullOrEmpty(parValue))
                    {
                        parValue += parArray[j];
                    }
                    else
                    {
                        parValue += ":" + parArray[j];
                    }
                }

                myParameters.Add(parKey, parValue);
            }
        }
        return myParameters;

    }
}
