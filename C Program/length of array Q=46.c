#include<stdio.h>
#include<conio.h>
int main()
{
	int num[5],i,n=0;
	printf("Enter any 5 number:\n");
	for(i=0;i<5;i++);
	{
		printf("num[%d]=",i);
		scanf("%d",&num[i]);
		}
		printf("Elements of an array less than 5 are \n");
		for(i=0;i<5;i++)
		{
			if(num[i]<5)
			{
				printf("num[%d]=%d\n",i,num[i]);
				n=n+1;
			}
		}
		if(n==0)
		printf("No element found");
}