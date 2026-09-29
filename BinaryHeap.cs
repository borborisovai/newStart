namespace newStart;

public class BinaryHeap
{
    private List<int> list = new();

    public int heapSize
    {
        get
        {
            return this.list.Count();
        }
    }

    public void Add(int value)
    {
        list.Add(value);
        int i = heapSize - 1;
        int parent = (i - 1) / 2;

        while (i > 0 && list[parent] < list[i])
        {
            int temp = list[i];
            list[i] = list[parent];
            list[parent] = temp;

            i = parent;
            parent = (i - 1) / 2;
        }
    }

    public void Heapify(int i)
    {
        int leftChild;
        int rightChild;
        int largestChild;

        while(true)
        {
            leftChild = 2 * i + 1;
            rightChild = 2 * i + 2;
            largestChild = i;

            if (leftChild < heapSize && list[leftChild] > list[largestChild])
            {
                largestChild = leftChild;
            }

            if (rightChild < heapSize && list[rightChild] > list[largestChild])
            {
                largestChild = rightChild;
            }

            if (largestChild == i)
            {
                break;
            }

            int temp = list[i];
            list[i] = list[largestChild];
            list[largestChild] = temp;
            i = largestChild;
        }
    }

    public void BuildHeap(int[] sourceArray)
    {
        list = sourceArray.ToList();
        for (int i = heapSize / 2; i >= 0; i--)
        {
            Heapify(i);
        }
    }

    public int GetMax()
    {
        int result = list[0];
        list[0] = list[heapSize - 1];
        list.RemoveAt(heapSize - 1);
        return result;
    }

    public void HeapSort(int[] array)
    {
        BuildHeap(array);
        for (int i = array.Length - 1; i >= 0; i--)
        {
            array[i] = GetMax();
            Heapify(0);
        }
    }

    public int Pop()
    {
        if (heapSize == 0)
            return 0;

        int result = GetMax();

        if (heapSize > 0)
        {
            Heapify(0);
        }

        return result;
    }

    public bool Pop(int value)
    {
        int index = list.IndexOf(value);

        if (index == -1)
            return false;

        int last = list[heapSize - 1];
        list.RemoveAt(heapSize - 1);

        if (index == heapSize)
            return true;

        list[index] = last;

        int parent = (index - 1) / 2;

        if (index > 0 && list[index] > list[parent])
        {
            int i = index;
            while (i > 0 && list[parent] < list[i])
            {
                int temp = list[i];
                list[i] = list[parent];
                list[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }
        else
        {
            Heapify(index);
        }

        return true;
    }

    public void Print()
    {
        Console.WriteLine("Heap array: [" + string.Join(", ", list) + "]");
    }

}
