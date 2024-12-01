using sortinterface;

public class Sort : I100e
{



    public void BubbleSort(int[] element)
    {
        int n = element.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (element[j] > element[j + 1])
                {
                    int temp = element[j];
                    element[j] = element[j + 1];
                    element[j + 1] = temp;
                }
            }
        }
    }


    public void InsertionSort(int[] element)
    {
        int n = element.Length;
        for (int i = 1; i < n; i++)
        {
            int key = element[i];
            int j = i - 1;

            while (j >= 0 && element[j] > key)
            {
                element[j + 1] = element[j];
                j--;
            }
            element[j + 1] = key;
        }
    }


    public void SelectionSort(int[] element)
    {
        int n = element.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (element[j] < element[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = element[minIndex];
            element[minIndex] = element[i];
            element[i] = temp;
        }
    }


    public void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }


    public void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        int iIndex = 0, jIndex = 0, kIndex = left;
        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                array[kIndex] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                array[kIndex] = rightArray[jIndex];
                jIndex++;
            }
            kIndex++;
        }

        while (iIndex < n1)
        {
            array[kIndex] = leftArray[iIndex];
            iIndex++;
            kIndex++;
        }

        while (jIndex < n2)
        {
            array[kIndex] = rightArray[jIndex];
            jIndex++;
            kIndex++;
        }
    }
}
