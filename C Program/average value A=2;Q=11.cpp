#include<stdio.h>
#include<conio.h>
int main()
{
	float w1,c1,w2,c2,r;
	printf("Weight- Item1:");
	scanf("%f",&w1);
	printf("NO. OF Item1:");
	scanf("%f",&c1);
	printf("Weight-Item2:");
	scanf("%f",&w2);
	printf("No.of Item:");
	scanf("%f",&c2);
	r=((w1*c1)+(w2*c2))/(c1+c2);
	printf("Average value Item=%f\n",r);
}