#include<stdio.h>
#include<conio.h>
int main()
{
	float num[5];
	int a,b=0,c=0;
	printf("Enter 1st number:\n");
	scanf("%f",&num[0]);
	printf("Enter 2nd number:\n");
	scanf("%f",&num[1]);
	printf("Enter 3 rd number:\n");
	scanf("%f",&num[2]);
	printf("Enter 4th number:\n");
	scanf("%f",&num[3]);
	printf("Enter 5th number:\n");
	scanf("%f",&num[4]);
	for(a=0;a<5;a++)
	{
		if(num[a]>0)
		{
			b++;
		}
		else if(num[a]<0)
		{
			c++;
		}
	}
	printf("\nNumber of positive number:%d",b);
	printf("\nNumber of negative number:%d",c);
}