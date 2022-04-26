#include<stdio.h>
#include<conio.h>
int main()
{
	int x;
	float y;
	printf("Enter total distance in km:");
	scanf("%d",&x);
	printf("Enter total fuel spent in liters:");
	scanf("%f",&y);
	printf("Average consumption(km/lit):%.3f",x/y);
	printf("\n");
}