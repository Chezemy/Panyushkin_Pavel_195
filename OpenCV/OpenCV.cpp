#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <opencv2/imgproc/imgproc.hpp>
using namespace cv;
using namespace std;
int main() 
{
	int height = 520;
	int width = 840;
	Mat img(height, width, CV_8UC3);
	Point textOrg(100, img.rows / 2);
	int fontFace = FONT_HERSHEY_SCRIPT_SIMPLEX;
	double fontScale = 4;
	Scalar color(200, 100, 50);
	putText(img, "Text", textOrg, fontFace, fontScale, color);
	namedWindow("Hello World", 0);
	imshow("Hello World", img);
	waitKey(0);
	return 0;
}
