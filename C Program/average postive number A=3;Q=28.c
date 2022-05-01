#include<stdio.h>
#include<conio.h>
int main()
{
	float num[5],t=0,avg;
	int i,b=0;
	printf("Enter the 1st number:\n");
	scanf("%f",&num[0]);
	printf("Enter the 2nd number:\n");
	scanf("%f",&num[1]);
	printf("Enter the 3rd number:\n");
	scanf("%f",&num[2]);
	printf("Enter the 4th number:\n");
	scanf("%f",&num[3]);
	printf("Enter the 5th number:\n");
	scanf("%f",&num[4]);
	for(i=0;i<5;i++)
	{
		if(num[i]>0)
	{
		b++;
		t+=num[i];
	}
	}
  avg = t/b;
  printf("Positive number:%d\n",b);
  printf("Average postive number:%.2f",avg);
}
