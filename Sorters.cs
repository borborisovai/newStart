namespace newStart;

public static class Sorters
{
    public static IEnumerable<T> Order<T>(IEnumerable<T> list, Func<T, T, int> compare)
    {
        IEnumerator<T> enumerator = list.GetEnumerator();

        T[] result = new T[0];

        // foreach(T item in list)
        while (enumerator.MoveNext())
        {
            Debug("Start!");
            T item = enumerator.Current;
            int pos = 0;


            Array.Resize(ref result, result.Length + 1);
            for (int i = result.Length - 2; i > -1; i--)
            {
                if (compare(item, result[i]) < 0)
                {
                    // Debug($"hit! {pos} + {result.Length} + {i}");
                    result[i + 1] = result[i];
                }
                else
                {
                    // Debug($"hot! + {compare(item, result[i])} + {result.Length} + {i} + {item} + {result[i]}");
                    pos = i + 1;
                    break;
                }
            }

            // result.Insert(pos, item);

            // Debug(pos.ToString() + result.Length.ToString());
            result[pos] = item;
            // Dumb(result);
        }
        return result;
    }



    public static void Debug(string log)
    {
        Console.WriteLine("[ДЕБУГ] " + log);
    }
    public static void Debug(int log)
    {
        Console.WriteLine("[ДЕБУГ] " + log.ToString());
    }
    public static void Dumb<T>(IEnumerable<T> list)
    {
        Console.Write("[Думб] {");
        foreach (T i in list)
        {
            Console.Write($"[{i}], ");
        }
        Console.Write("} \n");
    }
}
