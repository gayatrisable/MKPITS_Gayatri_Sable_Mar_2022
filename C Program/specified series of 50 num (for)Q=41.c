#include<stdio.h>
#include<conio.h>
int main()
{
	int i;
	float s=0;
	for (i=1;i<=50;i++)
	{
		s+=(float)1/i;
	}
	printf("value of S: %.2f\n",s);
}