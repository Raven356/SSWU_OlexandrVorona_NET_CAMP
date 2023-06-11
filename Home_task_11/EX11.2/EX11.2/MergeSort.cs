namespace EX11._2
{
    internal class MergeSort
    {
        private void Merge(int[] arr, int start, int middle, int end)
        {
            StreamWriter fileWriter = new StreamWriter("firstPart.txt");

            int firstPartLength = middle - start + 1;
            int secondPartLength = end - middle;

            int i, j;

            for (i = 0; i < firstPartLength; ++i)
                fileWriter.WriteLine(arr[start + i]);

            fileWriter.Dispose();

            fileWriter = new StreamWriter("secondPart.txt");
            for (j = 0; j < secondPartLength; ++j)
                fileWriter.WriteLine(arr[middle + 1 + j]);

            fileWriter.Dispose();

            CreateResultFile(firstPartLength, secondPartLength, "firstPart.txt", "secondPart.txt", "tempResult.txt");
            using StreamReader streamReader = new StreamReader("tempResult.txt");
            int k = start;
            while (!streamReader.EndOfStream)
            {
                arr[k] = int.Parse(streamReader.ReadLine());
                k++;
            }
            streamReader.Dispose();
            FileWorker.DeleteFile("tempResult.txt");
        }

        private void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;

                Sort(arr, start, middle);
                Sort(arr, middle + 1, end);

                Merge(arr, start, middle, end);
            }
        }

        public void Sort100Array(string path)
        {
            using StreamReader streamReader = new StreamReader(path);

            int[] arr = new int[50];

            FileWorker.ReadPartFromFile(streamReader, arr);

            Sort(arr, 0, arr.Length - 1);

            FileWorker.WritePartInFile("firstPartResult.txt", arr);

            FileWorker.ReadPartFromFile(streamReader, arr);

            Sort(arr, 0, arr.Length - 1);

            FileWorker.WritePartInFile("secondPartResult.txt", arr);

            streamReader.Dispose();

            CreateResultFile(50, 50, "firstPartResult.txt", "secondPartResult.txt", "startFile.txt");
        }

        private void CreateResultFile(int firstPartLength, int secondPartLength, string firstPartName
            , string secondPartName, string resultName)
        {
            using StreamWriter streamWriter = new StreamWriter(resultName);
            using StreamReader firstPartReader = new StreamReader(firstPartName);
            using StreamReader secondPartReader = new StreamReader(secondPartName);

            int i = 0;
            int j = 0;

            int firstPartElement = int.Parse(firstPartReader.ReadLine());
            int secondPartElement = int.Parse(secondPartReader.ReadLine());
            while (i < firstPartLength && j < secondPartLength)
            {
                if (firstPartElement <= secondPartElement)
                {
                    streamWriter.WriteLine(firstPartElement);
                    if (i + 1 < firstPartLength)
                        firstPartElement = int.Parse(firstPartReader.ReadLine());
                    i++;
                }
                else
                {
                    streamWriter.WriteLine(secondPartElement);
                    if (j + 1 < secondPartLength)
                        secondPartElement = int.Parse(secondPartReader.ReadLine());
                    j++;
                }
            }

            while (i < firstPartLength)
            {
                streamWriter.WriteLine(firstPartElement);
                if (i + 1 < firstPartLength)
                    firstPartElement = int.Parse(firstPartReader.ReadLine());
                i++;
            }
            while (j < secondPartLength)
            {
                streamWriter.WriteLine(secondPartElement);
                if (j + 1 < secondPartLength)
                    secondPartElement = int.Parse(secondPartReader.ReadLine());
                j++;
            }
            firstPartReader.Dispose();
            secondPartReader.Dispose();
            FileWorker.DeleteFile(firstPartName);
            FileWorker.DeleteFile(secondPartName);
        }
    }
}
