#include<stdio.h>
#include<conio.h>
void swap(int x,int y)
{
	int temp;
	temp=x;
	x=y;
	y=temp;
	printf("x=%d y=%d\n",x,y);
}
int main()
{
	int a=10,b=20;
	swap(a,b);
	printf("a=%d b=%d",a,b);
	getch();
	return 0;
}