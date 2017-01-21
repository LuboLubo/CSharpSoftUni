using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        {
            Dictionary<int, Dictionary<string, List<string>>> dicOutput = new Dictionary<int, Dictionary<string, List<string>>>();

            string inputLine = Console.ReadLine();
            while (!inputLine.Equals("Time for Code"))
            {
                string[] inputSplit = inputLine.Split(' ');
                int id = int.Parse(inputSplit[0]);
                string name = inputSplit[1];
                string firstIndex = inputSplit[1];
                List<string> list = new List<string>(inputSplit.Skip(2));
                if (firstIndex[0] != '#')
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                if (!dicOutput.ContainsKey(id))
                {
                    dicOutput.Add(id, new Dictionary<string, List<string>>());
                    dicOutput[id][name] = list;
                }


                else
                {
                    if (!dicOutput[id].ContainsKey(name))
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        foreach (var word in list)
                        {
                            dicOutput[id][name].Add(word);
                        }
                    }

                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (var item in dicOutput.OrderByDescending(x => x.Value.Values.Max(y => y.Count)))
            {
                List<string> temporarity = new List<string>();
                foreach (var ite in item.Value)
                {
                    temporarity = ite.Value.Distinct().ToList();
                    temporarity.Sort();
                    int count = temporarity.Count;
                    Console.WriteLine($"{ite.Key.TrimStart('#')} - {count}");

                }

                foreach (var word in temporarity)
                {
                    Console.WriteLine($"{word}");
                }


            }
            Console.WriteLine();
        }
    }
}










