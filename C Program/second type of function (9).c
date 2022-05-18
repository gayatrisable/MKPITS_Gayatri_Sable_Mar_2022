#include<stdio.h>
#include<conio.h>
void fun(int);
int main()
{
	int num;
	fun(num);
}
void fun(int)
{
	int i;
	for(i=1;i<=10;i++)
	{
		printf("\n%d",i);
	}
}
