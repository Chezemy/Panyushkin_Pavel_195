#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <stdio.h>
#include <stdlib.h>
#include <string>
#include <iostream>
using namespace cv;
using namespace std;

Mat img;


int main()
{
	setlocale(LC_ALL, "Russian");
	char filename[80];
	cout << "Enter file name" << endl;
	cout << "Obama.jpg" << endl;
	cout << "Putin.jpg" << endl;
	cout << "Rock.jpg" << endl;

	cin.getline(filename, 80);
	cout << "Open file: ";
	cout << filename << endl;

	Mat img = imread(filename, 1);
	const char* source_window = filename;

	namedWindow(source_window, WINDOW_GUI_EXPANDED);
	imshow(source_window, img);

	Mat src_gray;
	Mat canny_output;

	cvtColor(img, src_gray, COLOR_RGB2GRAY);
	imwrite("cvtColor.jpg", src_gray);
	blur(src_gray, src_gray, Size(10, 10));
	imwrite("blur.jpg", src_gray);

	double otsu_tresh_val = threshold(src_gray, img, 0, 255, THRESH_BINARY | THRESH_OTSU);
	double high_tresh_val = otsu_tresh_val, lower_tresh_val = otsu_tresh_val * 0.5;

	cout << otsu_tresh_val;
	Canny(src_gray, canny_output, lower_tresh_val, high_tresh_val, 3);

	string source_grey_window = "abc";
	namedWindow(source_grey_window, WINDOW_GUI_EXPANDED);
	imshow(source_grey_window, canny_output);
	imwrite("canny_output.jpg", canny_output);

	waitKey(0);
	return(0);
}