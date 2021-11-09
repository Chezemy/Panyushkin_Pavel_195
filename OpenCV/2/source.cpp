#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <iostream>
#include <stdio.h>
#include <stdlib.h> // подключены все необходимые библиотеки

using namespace cv;
using namespace std; // подключены пространства имён

Mat img;
Mat src_gray;


int main()
{
	setlocale(LC_ALL, "Russian"); 
	char filename[80];  
	cout << "Введите имя файла, в который хотите внести изменения, и нажмите Enter" << endl; // вывод сообщение в консоль
	cin.getline(filename, 80);
	cout << "Открыт файл";
	cout << filename << endl;

	Mat img = imread(filename, 1); // открытие необходимого изображения
	namedWindow("Исходное изображение", WINDOW_AUTOSIZE); // название и размер окна с исходным изображением
	imshow("Исходное изображение", img); // создаёт окно с открытым исходным изображением



	Mat canny_output;
	cvtColor(img, src_gray, COLOR_RGB2GRAY); // перводит изображение в черно-белое
	blur(src_gray, src_gray, Size(3, 3)); //размывает изображение

	double otsu_thresh_val = threshold(src_gray, img, 0, 255, THRESH_BINARY | THRESH_OTSU); //определяет яркость серого изображения
	double high_thresh_val = otsu_thresh_val, lower_thresh_val = otsu_thresh_val * 0.5; //определяет максимумы и минимумы
	cout << otsu_thresh_val;
	Canny(src_gray, canny_output, lower_thresh_val, high_thresh_val, 3); // параметр 3 - трёхканальное изображение

	namedWindow("Серое изображение", WINDOW_AUTOSIZE); // название и размер окна с обработанным изображением
	imshow("Серое изображение", canny_output);
	imwrite("canny_output.jpg", canny_output); //сохраняет и открывает обработанное изображение

	waitKey(0);
	return 0;
}