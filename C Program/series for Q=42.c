#include<stdio.h>
#include<conio.h>
int main()
{
	double s=0,j=1,d,i;
	for(i=1;i<=7;i+=2)
	{
		d=(i/j);
		s+=d;
		j=j*2;
	}
	printf("value of series:%5lf\n",s);
}