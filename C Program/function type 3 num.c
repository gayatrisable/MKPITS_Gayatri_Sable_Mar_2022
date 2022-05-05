#include<stdio.h>
#include<conio.h>
int x1,x2;//global decleration
int fun();
int main()
{
	int s;
	s=fun();
	if(s==0)
	{
	 printf("%d is smaller",x1);	
	}
	else
	{
		printf("%d is smaller",x2);
	}
}
//returntyoe and no arguement
int fun()
{
	printf("Enter two number\n");
	scanf("%d%d",&x1,&x2);
	if(x1<x2)
	{
		return 0;
	}
	else
	{
		return 1;
	}
	}	