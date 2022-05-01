#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b,c=1,d=0;
	printf("Enter the number of lines:");
	scanf("%d",&a);
	for(b=1;b<=a;b++)
	{
		while(d<3)
		{
			printf("%d ",c++);
			d++;
		}
		d=0;
		printf("\n");
	}
}