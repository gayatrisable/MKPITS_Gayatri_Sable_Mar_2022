#include<stdio.h>
#include<conio.h>
int fun(int,int);
int main()
{
	int x,y,s;
	printf("enter the value of x :");
	scanf("%d",&x);
	printf("enter the value of y :");
	scanf("%d",&y);
	if(s==0)
	{
		printf("%d is smaller",x);
	}
	else
	{
		printf("%d is smaller",y);
	}
	
}
	int fun(int x,int y)
	{
		if(x<y)
		{
		return 0;
	    }
	    else
	    {
	    	return 1;
		}
	}
	
