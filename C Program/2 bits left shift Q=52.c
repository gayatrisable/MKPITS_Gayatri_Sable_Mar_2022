#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b;
	printf("Enter the value=");
	scanf("%d",&a);
	a<<=2;
	b=a;
	printf("The left shifted data is=%d",b);
}