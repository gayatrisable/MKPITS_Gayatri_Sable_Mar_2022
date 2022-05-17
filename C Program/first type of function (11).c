#include<stdio.h>
#include<conio.h>
void fun();
int main()
{
	fun();
}
void fun()
{
	int i;
	i=1;
	do
	{
		printf("\n%d ",i);
		i++;
	}while(i<=10);
}

