#include<stdio.h>
#include<conio.h>
void fun(int,int);
int main()
{
	int x,y;
	printf("enter the value of x :");
	scanf("%d",&x);
	printf("enter the value of y :");
	scanf("%d",&y);
	fun(x,y);
}
void fun(int x,int y)
{
	if(x<y)
	{
		printf("x is smaller");
    }
    if(x>y)
    {
    	printf("y is smaller");
	}
}
