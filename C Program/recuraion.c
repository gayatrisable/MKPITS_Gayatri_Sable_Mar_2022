#include<stdio.h>
#include<conio.h>
int i=1;
void fun();
void main()
{
   fun();	
}
void fun()
{
//	int i=1;
 if(i==10)
 return;
	printf("%d",i);
	i++;
	fun();
}