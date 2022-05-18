#include<stdio.h>
#include<conio.h>
void fun(int);
int main()
{
	int num;
	fun(num);
}
void fun(int num)
{
	int i;
	for(i=1;i<=10;i++)
	{
		if(i%2==0)
		{
			printf("\n%d",i);
		}
	}
}
