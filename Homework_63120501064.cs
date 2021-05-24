using System;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Address of the imported image data file. : ");
            string InputFile = Console.ReadLine(); //C:\Users\Pai\source\repos\Homework5\test.txt\InputImage.txt
            Console.Write("Address of the Convolution Kernel data file. : ");
            string DataFileConvolutionKernel = Console.ReadLine(); //C:\Users\Pai\source\repos\Homework5\test.txt\ConvolutionKernel.txt
            Console.Write("Address of the output image data file. : ");
            string DataFileOutput = Console.ReadLine(); //C:\Users\Pai\source\repos\Homework5\test.txt\OutputImage.txt

            //InputFile
            double[,] imageDataInputFile = ReadImageDataFromFile (InputFile);

            //InputConvolutionKernel
            double[,] imageDataConvolution = ReadImageDataFromFile (DataFileConvolutionKernel);


            //ขยาดarray
            int ArrayCollumn = imageDataInputFile.GetLength(0) * imageDataConvolution.GetLength(0) - 1;
            int ArrayRow = imageDataInputFile.GetLength(0) * imageDataConvolution.GetLength(0) - 1;

            //สร้างarray
            // double[,] DataArray = WriteDataArray(imageDataInputFile, imageDataInputFile.GetLength(0),imageDataInputFile.GetLength(1));

            //Convolve
            //double[,] OutputImageData = ConvolutionOutput(DataArray, imageDataConvolution, imageDataInputFile.GetLength(0), imageDataInputFile.GetLength(1));

            //Output
            // WriteImageDataToFile(DataFileOutput, OutputImageData);

            for (int i = -1; i <= 5; i++)
            {
                int newi = (i + 5) % 5;
                for (int j = -1; j <= 5; j++)
                {
                    int newj = (j + 5) % 5;
                    Console.Write("{0}   ", imageDataInputFile[newi, newj]);
                }
                Console.WriteLine();
            }
            /*
                        static double[,] WriteDataArray(double[,] imageDataInputFile, int ImageDataInputFileCollumn,int ImageDataInputFileRow)
                        {
                            //forloopimageDataInputFile
                            double[,] InputDataFile = new double[ImageDataInputFileCollumn, ImageDataInputFileRow];
                            for (int i = -1; i <= 5; i++)
                            {
                                int newi = (i + 5) % 5;
                                for (int j = -1; j <= 5; j++)
                                {
                                    int newj = (j + 5) % 5;
                                    InputDataFile[i,j] = imageDataInputFile[newi, newj];
                                }
                                Console.WriteLine();
                            }
                            return InputDataFile;
                        }
            */

        }
        static double[,] ConvolutionOutput(double[,] DataArray, double[,] convolutionArray, int dataArrayCollumn, int dataArrayRow)
        {
            double[,] OutputImageDataArray = new double[dataArrayCollumn, dataArrayRow];
            for (int i = 0; i < dataArrayCollumn; i++)
            {
                for (int j = 0; j < dataArrayRow; j++)
                {
                    for (int k = 0; k < convolutionArray.GetLength(0); k++)
                    {
                        for (int l = 0; l < convolutionArray.GetLength(1); i++)
                        {
                            OutputImageDataArray[i, j] += DataArray[i + k, j + l] * convolutionArray[k, l];
                        }
                    }
                }
            }
            return OutputImageDataArray;
        }
    }
    }

