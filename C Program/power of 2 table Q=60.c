#include<stdio.h>
#include<conio.h>
int main()
{
	int i,pow=1;
	float neg;
	for(i=1;i<=10;i++)
	{
		if(i==0)
		{
			pow=1;
		}
		else
		{
			pow=pow*2;
			neg=1.0/pow;
		}
		printf("%d  %d  %f\n",i,pow,neg);
	}
}