#include<stdio.h>
#include<conio.h>
int main()
{
	float a,b,c,peri,area;
	printf("Enter the 1 st value:");
	scanf("%f",&a);
	printf("\nEnter the 2nd value:");
	scanf("%f",&b);
	printf("\nEnter the 3rd value:");
	scanf("%f",&c);
	if(a<(b+c)&&b<(a+c)&&c<(b+a))
	{
		peri=a+b+c;
		printf("\nPerimeter=%.1f\n",peri);
	}
	else
	{
		printf("Not possible to create tringle");
	}
}