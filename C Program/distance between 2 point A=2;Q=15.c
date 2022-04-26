#include<stdio.h>
#include<conio.h>
#include<math.h>
int main()
{
	float x1,y1,x2,y2,dist;
	printf("Enter point 1 (x1,y1)\n");
	scanf("%f%f",&x1,&y1);
	printf("Enter point 2 (y2,y2)\n");
	scanf("%f%f",&x2,&y2);
	dist=sqrt(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
	printf("distance between(%0.2f,%0.2f)and(%0.2f,%0.2f)is %0.2f\n",x1,y1,x2,y2,dist);
}